import fs from "fs/promises";


export class Exercise {
    rivalGame: { [clave: string]: Game } = {
        A: Game.Rock,
        B: Game.Paper,
        C: Game.Scissors,
    };

    playerGame: { [clave: string]: Game } = {
        X: Game.Rock,
        Y: Game.Paper,
        Z: Game.Scissors,
    };


    async part1(): Promise<number> {
        let finalResult: number = 0;
        let text = await this.readFileAsync();

        for (const line of text) {
            let options = line.split(" ");
            let rivalOpt = (this.rivalGame)[options[0]]
            let playerOpt = (this.playerGame)[options[1]];
            let result = this.isPlayerWin(rivalOpt, playerOpt);


            switch (result) {
                case GameResult.draw:
                    finalResult += 3;
                    break;
                case GameResult.Win:
                    finalResult += 6;
                    break;
            }
            finalResult += this.scoreOpt(playerOpt);
        }

        return finalResult;
    }

    async part2() {
        let finalResult: number = 0;
        let text = await this.readFileAsync();

        for (const line of text) {
            let options = line.split(" ");
            let rivalOpt = (this.rivalGame)[options[0]]
            let playerOpt = options[1];

            let playerGame: Game = Game.Paper;

            const checkPlayerWins = (playerOpt: string, rivalOpt: Game) => {
                if (playerOpt == "X") {
                    playerGame = rivalOpt == Game.Paper
                        ? Game.Rock : rivalOpt == Game.Rock
                            ? Game.Scissors : rivalOpt == Game.Scissors
                                ? Game.Paper : Game.Paper;
                    return GameResult.defeat;
                }
                if (playerOpt == "Y") {
                    playerGame = rivalOpt;
                    return GameResult.draw;

                }
                if (playerOpt == "Z") {
                    playerGame = rivalOpt == Game.Paper
                        ? Game.Scissors : rivalOpt == Game.Rock
                            ? Game.Paper : rivalOpt == Game.Scissors
                                ? Game.Rock : Game.Paper;
                    return GameResult.Win;
                }
            };

            let result = checkPlayerWins(playerOpt, rivalOpt);

            switch (result) {
                case GameResult.draw:
                    finalResult += 3;
                    break;
                case GameResult.Win:
                    finalResult += 6;
                    break;
            }
            finalResult += this.scoreOpt(playerGame);
        }

        return finalResult;
    }

    private scoreOpt(gameOpt: Game): number {
        switch (gameOpt) {
            case Game.Rock:
                return 1;
            case Game.Paper:
                return 2;
            case Game.Scissors:
                return 3;
            default:
                return 0;
        }
    }

    private isPlayerWin(rival: Game, player: Game): GameResult {
        if (rival === player)
            return GameResult.draw;

        if ((rival === Game.Paper && player === Game.Scissors)
            || (rival === Game.Scissors && player === Game.Rock)
            || (rival === Game.Rock && player === Game.Paper)) {
            return GameResult.Win
        }
        return GameResult.defeat;
    }

    private async readFileAsync() {
        const filePath = "./text.txt";

        let content = await fs.readFile(filePath, "utf8");

        // content = "A Y\n" +
        //     "B X\n" +
        //     "C Z";

        return content.split("\n").map((line) => line.trim());
    }
}

enum Game {
    Paper,
    Rock,
    Scissors
}

enum GameResult {
    Win,
    defeat,
    draw
}
