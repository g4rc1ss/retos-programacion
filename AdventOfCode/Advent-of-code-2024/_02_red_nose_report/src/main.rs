use std::fs::File;
use std::io::{BufRead, BufReader};

fn main() -> std::io::Result<()> {
    let part1 = resolve_part1();
    let part2 = resolve_part2();

    println!("=============================");
    println!("Part1: {}", part1);
    println!("Part2: {}", part2);
    println!("=============================");

    Ok(())
}

fn resolve_part1() -> i32 {
    let reports = get_text().unwrap();
    let reports_len = reports.len();
    // let mut reports: Vec<String> = Vec::new();
    // reports.push(String::from("7 6 4 2 1"));
    // reports.push(String::from("1 2 7 8 9"));
    // reports.push(String::from("9 7 6 2 1"));
    // reports.push(String::from("1 3 2 4 5"));
    // reports.push(String::from("8 6 4 4 1"));
    // reports.push(String::from("1 3 6 7 9"));
    let mut unsafe_result: Vec<String> = Vec::new();

    for report in reports {
        let levels: Vec<&str> = report.split_whitespace().collect();
        let is_succeded = check_data(&levels);

        if !is_succeded {
            unsafe_result.push(report);
        }
    }
    (reports_len - unsafe_result.len()) as i32
}

fn resolve_part2() -> i64 {
    let reports = get_text().unwrap();
    // let mut reports: Vec<String> = Vec::new();
    // reports.push(String::from("7 6 4 2 1"));
    // reports.push(String::from("1 2 7 8 9"));
    // reports.push(String::from("9 7 6 2 1"));
    // reports.push(String::from("1 3 2 4 5"));
    // reports.push(String::from("8 6 4 4 1"));
    // reports.push(String::from("1 3 6 7 9"));

    let reports_len = reports.len();
    let mut unsafe_result: Vec<String> = Vec::new();

    for report in reports {
        println!("{}", report);
        let mut levels: Vec<&str> = report.split_whitespace().collect();
        let is_succeded = check_data(&levels);

        if !is_succeded {
            let mut is_succeded_retry = false;
            for i in 0..levels.len() {
                let mut levels_copy = levels.clone();
                levels_copy.remove(i);

                is_succeded_retry = check_data(&levels_copy);
                if is_succeded_retry {
                    break;
                }
            }
            if !is_succeded_retry {
                unsafe_result.push(report);
            }
        }
    }
    (reports_len - unsafe_result.len()) as i64
}

fn check_data(levels: &Vec<&str>) -> bool {
    let mut is_succeded: bool = true;
    let mut is_ascending = false;

    for i in 0..levels.len() {
        println!("{}", levels[i]);

        if !(i + 1 < levels.len()) {
            break;
        }
        let actual: i32 = levels[i].parse().unwrap();
        let next: i32 = levels[i + 1].parse().unwrap();

        if actual == next {
            is_succeded = false;
            break;
        }
        let absolute = (actual - next).abs();

        if !(absolute >= 1 && absolute <= 3) {
            is_succeded = false;
            break;
        }

        if i > 0 {
            let previous: i32 = levels[i - 1].parse().unwrap();
            is_ascending = previous < actual && actual < next;

            if (is_ascending && !(previous < actual && actual < next))
                || (!is_ascending && !(previous > actual && actual > next))
            {
                is_succeded = false;
                break;
            }
        }
    }
    is_succeded
}

fn get_text() -> std::io::Result<Vec<String>> {
    let binding = File::open("./src/text.txt")?;
    let contenido = BufReader::new(binding);

    return Ok(contenido.lines().map(|l| l.unwrap()).collect());
}
