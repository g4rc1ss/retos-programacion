use std::collections::HashMap;
use std::fs::File;
use std::io::{BufRead, BufReader};

fn main() -> std::io::Result<()> {
    let part1 = resolve_part1();
    let part2 = resolve_part2();

    println!("=============================");
    println!("Part2: {}", part1);
    println!("Part1: {}", part2);
    println!("=============================");

    Ok(())
}

fn resolve_part1() -> i32 {
    let columns_text = get_text_columns().unwrap();

    let mut distance: Vec<i32> = Vec::new();
    for i in 0..columns_text.column2.len() {
        println!("------------------------------------------------");
        let column1_value = columns_text.column1[i];
        let column2_value = columns_text.column2[i];

        println!(
            "{0}   {1}",
            column1_value.to_string(),
            column2_value.to_string()
        );
        if column1_value > column2_value {
            distance.push(column1_value - column2_value);
        } else {
            distance.push(column2_value - column1_value);
        }

        println!("{}", distance[i].to_string());
    }

    let mut final_result: i32 = 0;
    for dist in distance {
        final_result += dist;
    }

    return final_result;
}

fn resolve_part2() -> i64 {
    let columns_text = get_text_columns().unwrap();
    let mut counter_name: HashMap<i32, i32> = HashMap::new();
    let mut final_result: i64 = 0;

    for column1 in columns_text.column1 {
        if counter_name.contains_key(&column1) {
            continue;
        }
        counter_name.insert(column1, 0);
    }

    for column2 in columns_text.column2 {
        if counter_name.contains_key(&column2) {
            counter_name.insert(column2, counter_name.get(&column2).unwrap() + 1);
            let prueba = counter_name.get(&column2).unwrap();
            println!("{0}", prueba.to_string());
        }
    }

    for count in counter_name {
        let repeat: i64 = (count.0 * count.1) as i64;
        final_result += repeat;
    }

    return final_result;
}

fn get_text_columns() -> std::io::Result<Columns> {
    let binding = File::open("./src/ParList.txt")?;
    let contenido = BufReader::new(binding);

    let mut column1: Vec<i32> = Vec::new();
    let mut column2: Vec<i32> = Vec::new();

    for column in contenido.lines() {
        let result = column.ok().unwrap();
        let x: Vec<&str> = result.split("   ").collect();

        column1.push(x[0].parse().unwrap());
        column2.push(x[1].parse().unwrap());

        println!("{0}   {1}", x[0].to_string(), x[1].to_string());
    }
    column1.sort();
    column2.sort();

    let columns = Columns {
        column1: column1,
        column2: column2,
    };
    return Ok(columns);
}

struct Columns {
    column1: Vec<i32>,
    column2: Vec<i32>,
}
