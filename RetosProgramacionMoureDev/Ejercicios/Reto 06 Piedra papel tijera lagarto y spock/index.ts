enum game {
    piedra,
    papel,
    tijera,
    lagarto,
    spock
}

interface IPlayGame {
    player1: string,
    player2: string
}

let gameOptions: { [symbols: string]: game } = {
    "✂️": game.tijera,
    "🦎": game.lagarto,
    "🖖": game.spock,
    "🗿": game.piedra,
    "📄": game.papel,
}

// Variable que define que opcion gana a las demas
let wins: Map<game, game[]> = new Map<game, game[]>()
wins.set(game.piedra, [game.lagarto, game.tijera])
wins.set(game.papel, [game.piedra, game.spock])
wins.set(game.tijera, [game.papel, game.lagarto])
wins.set(game.lagarto, [game.spock, game.papel])
wins.set(game.spock, [game.tijera, game.piedra])

let entrada: IPlayGame[] = [
    { player1: "🗿", player2: "✂️" },
    { player1: "✂️", player2: "🗿" },
    { player1: "✂️", player2: "✂️" },
]

let player1Wins: number = 0
let player2Wins: number = 0
entrada.forEach(element => {
    let optionPlayer1: game = gameOptions[element.player1]
    let optionPlayer2: game = gameOptions[element.player2]

    if (wins.get(optionPlayer1)?.some(x => x == optionPlayer2)) {
        player1Wins++
    } else if (wins.get(optionPlayer2)?.some(x => x == optionPlayer1)) {
        player2Wins++
    }
});

if (player1Wins > player2Wins) {
    console.log("Ha ganado el player 1")
} else if (player2Wins > player1Wins){
    console.log("Ha ganado el Player 2")
} else{
    console.log("Tie")
}