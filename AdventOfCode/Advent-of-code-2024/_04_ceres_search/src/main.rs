use std::collections::HashMap;
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
    let text: Vec<Vec<char>> = text.lines().map(|line| line.chars().collect()).collect();
    let mut final_result: i64 = 0;

    let directions = [
        (0, 1),   // derecha
        (0, -1),  // izquierda
        (1, 0),   // abajo
        (-1, 0),  // arriba
        (1, 1),   // diagonal abajo-derecha
        (1, -1),  // diagonal abajo-izquierda
        (-1, 1),  // diagonal arriba-derecha
        (-1, -1), // diagonal arriba-izquierda
    ];
    let text_to_find: Vec<_> = "XMAS".to_string().chars().collect();

    for x in 0..text.len() {
        for y in 0..text[x].len() {
            let line = x as i32;
            let column = y as i32;

            for (line_direction, column_direction) in directions {
                let result = check_words(
                    &text,
                    line,
                    column,
                    text_to_find.clone(),
                    line_direction,
                    column_direction,
                );
                final_result += if result { 1 } else { 0 };
            }
        }
    }
    final_result
}

fn resolve_part2() -> i64 {
    let text = get_text().unwrap();
    let text: Vec<Vec<char>> = text.lines().map(|line| line.chars().collect()).collect();
    let mut final_result: i64 = 0;

    let directions = [
        (1, 1),   // diagonal abajo-derecha
        (1, -1),  // diagonal abajo-izquierda
        (-1, 1),  // diagonal arriba-derecha
        (-1, -1), // diagonal arriba-izquierda
    ];

    let text_to_find: Vec<_> = "MAS".to_string().chars().collect();
    let mut coordinates: HashMap<(i32, i32), i32> = HashMap::new();

    for x in 0..text.len() {
        for y in 0..text[x].len() {
            let line = x as i32;
            let column = y as i32;

            for (line_direction, column_direction) in directions {
                let result = check_words(
                    &text,
                    line,
                    column,
                    text_to_find.clone(),
                    line_direction,
                    column_direction,
                );
                if result {
                    // con esto obtenemos el indice de la palabra de en medio, la que se van a cruzar al formar la X
                    let index_middle_text = (text_to_find.len() / 2) as i32;

                    let mut index_line_middle_word = line;
                    let mut index_column_middle_word = column;

                    if line_direction.is_negative() {
                        index_line_middle_word -= index_middle_text;
                    } else {
                        index_line_middle_word += index_middle_text;
                    }

                    if column_direction.is_negative() {
                        index_column_middle_word -= index_middle_text;
                    } else {
                        index_column_middle_word += index_middle_text;
                    }

                    if coordinates.contains_key(&(index_line_middle_word, index_column_middle_word))
                    {
                        coordinates.insert(
                            (index_line_middle_word, index_column_middle_word),
                            coordinates
                                .get(&(index_line_middle_word, index_column_middle_word))
                                .unwrap()
                                + 1,
                        );
                    } else {
                        coordinates.insert((index_line_middle_word, index_column_middle_word), 1);
                    }
                }
            }
        }
    }

    for (coordinate, counter) in coordinates {
        if counter > 1 {
            println!("{:?} -> {}", coordinate, counter);
            final_result += 1;
        }
    }

    final_result
}

fn check_words(
    text: &Vec<Vec<char>>,
    line: i32,
    column: i32,
    find_text: Vec<char>,
    line_direction: i32,
    column_direction: i32,
) -> bool {
    let mut line_to_check = line;
    let mut column_to_check = column;

    for word_char in find_text {
        let is_possible_check_next = (line_to_check) > -1
            && (line_to_check) < text.len() as i32
            && (column_to_check) > -1
            && (column_to_check) < text[line_to_check as usize].len() as i32;

        if !is_possible_check_next {
            return false;
        }

        if is_possible_check_next
            && text[line_to_check as usize][column_to_check as usize] != word_char
        {
            println!(
                "Palabra de text rechazada: {}",
                text[line_to_check as usize][column_to_check as usize]
            );
            println!("Palabra rechazada {}", word_char);
            return false;
        }
        println!("Palabra aceptada {}", word_char);
        line_to_check += line_direction;
        column_to_check += column_direction;
    }
    true
}

fn get_text() -> std::io::Result<String> {
    let binding = File::open("./src/text.txt")?;
    let mut buffered = BufReader::new(binding);
    let mut contenido: String = String::new();

    buffered.read_to_string(&mut contenido)?;

    Ok(contenido)
}
