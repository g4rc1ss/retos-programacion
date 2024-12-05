use regex::Regex;
use std::fs::File;
use std::io::{BufReader, Read};

fn main() -> std::io::Result<()> {
    let part1 = resolve_part1();
    let part2 = resolve_part2();

    println!("=============================");
    println!("Part1: {}", part1);
    println!("Part2: {}", part2);
    println!("=============================");

    Ok(())
}

fn resolve_part1() -> i64 {
    let text = get_text().unwrap();

    let pattern = r"mul\((\d{1,3}),(\d{1,3})\)";
    let regex = Regex::new(pattern).unwrap();

    let matches = regex
        .find_iter(text.as_str())
        .map(|mat| mat.as_str())
        .collect::<Vec<&str>>();

    let mut final_result: i64 = 0;
    for mul in matches {
        println!("{}", mul);
        let pattern = r"(\d{1,3})";
        let regex = Regex::new(pattern).unwrap();
        let numbers = regex
            .find_iter(mul)
            .map(|mat| mat.as_str())
            .collect::<Vec<&str>>();

        let mut number_to_mul: i64 = 1;
        for number in numbers {
            println!("{}", number);
            let number_parsed: i64 = number.parse::<i64>().unwrap();
            number_to_mul *= number_parsed;
        }
        final_result += number_to_mul;
    }

    final_result
}

fn resolve_part2() -> i64 {
    let text = get_text().unwrap();

    let pattern = r"(do\(\))|(don't\(\))|(mul\((\d{1,3}),(\d{1,3})\))";
    let regex = Regex::new(pattern).unwrap();

    let matches = regex
        .find_iter(text.as_str())
        .map(|mat| mat.as_str())
        .collect::<Vec<&str>>();

    let mut final_result: i64 = 0;
    let mut previous_condition = "";
    for mul in matches {
        println!("{}", mul);

        if mul.contains("mul") && (previous_condition.is_empty() || previous_condition == "do()") {
            let pattern = r"(\d{1,3})";
            let regex = Regex::new(pattern).unwrap();
            let numbers = regex
                .find_iter(mul)
                .map(|mat| mat.as_str())
                .collect::<Vec<&str>>();

            let mut number_to_mul: i64 = 1;
            for number in numbers {
                println!("{}", number);
                let number_parsed: i64 = number.parse::<i64>().unwrap();
                number_to_mul *= number_parsed;
            }
            final_result += number_to_mul;
        } else if mul.contains("do()") || mul.contains("don't()") {
            previous_condition = mul;
        }
    }

    final_result
}

fn get_text() -> std::io::Result<String> {
    let binding = File::open("./src/text.txt")?;
    let mut buffered = BufReader::new(binding);
    let mut contenido: String = String::new();

    buffered.read_to_string(&mut contenido)?;

    Ok(contenido)
}
