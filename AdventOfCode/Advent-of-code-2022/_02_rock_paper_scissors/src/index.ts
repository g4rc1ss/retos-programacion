import {Exercise} from "./Exercise";

async function main() {
    let exercise = new Exercise();

    let PERF__start = Date.now();

    let part1 = await exercise.part1();
    let part2 = await exercise.part2();

    let PERF__end = Date.now();

    console.log('-------------------------------')
    console.log(`Part 1: ${part1}`);
    console.log(`Part 2: ${part2}`);
    console.log(`Tiempo: ${Math.floor((PERF__end - PERF__start) / 1000)}`);
    console.log('-------------------------------')

}

main();