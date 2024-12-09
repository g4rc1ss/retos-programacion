use std::collections::HashMap;
use std::fs::File;
use std::io::{BufRead, BufReader, Read};

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
    let mut text = get_text().unwrap();
    text = Vec::new();
    text.push(String::from("....#.....").chars().collect::<Vec<char>>());
    text.push(String::from(".........#").chars().collect::<Vec<char>>());
    text.push(String::from("..........").chars().collect::<Vec<char>>());
    text.push(String::from("..#.......").chars().collect::<Vec<char>>());
    text.push(String::from(".......#..").chars().collect::<Vec<char>>());
    text.push(String::from("..........").chars().collect::<Vec<char>>());
    text.push(String::from(".#..^.....").chars().collect::<Vec<char>>());
    text.push(String::from("........#.").chars().collect::<Vec<char>>());
    text.push(String::from("#.........").chars().collect::<Vec<char>>());
    text.push(String::from("......#...").chars().collect::<Vec<char>>());

    let indexes = localize_guard_and_obstacles(&text);
    let mut guard_direction = Directions::Up;
    let guard_index_x = indexes.0;
    let guard_index_y = indexes.1;

    for x in 0..text.len() {
        for y in 0..text[x].len() {

        }
    }

    print_text(&text);
    count_guard_path(&text)
}

fn localize_guard_and_obstacles(text: &Vec<Vec<char>>) -> ((usize, usize)) {
    for x in 0..text.len() {
        for y in 0..text[x].len() {
            let location = (x, y);
            if text[x][y] == '^' {
                return (x, y);
            }
        }
    }
    (0, 0)
}

fn count_guard_path(text: &Vec<Vec<char>>) -> i64 {
    let mut count: i64 = 0;
    for x in 0..text.len() {
        for y in 0..text[x].len() {
            if text[x][y] == 'X' {
                count += 1;
            }
        }
    }
    count
}

fn print_text(text: &Vec<Vec<char>>) {
    for x in 0..text.len() {
        for y in 0..text[x].len() {
            eprint!("{}", text[x][y]);
        }
        eprint!("\n");
    }
}

fn resolve_part2() -> i64 {
    let text = get_text().unwrap();
    let mut final_result: i64 = 0;

    final_result
}

fn get_text() -> std::io::Result<Vec<Vec<char>>> {
    let binding = File::open("./src/text.txt")?;
    let contenido = BufReader::new(binding);

    Ok(contenido
        .lines()
        .map(|l| l.unwrap().chars().collect::<Vec<char>>())
        .collect())
}
#[derive(Debug, Eq, PartialEq)]
enum Directions {
    Left,
    Right,
    Up,
    Down,
}
