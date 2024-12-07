use regex::Regex;
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
    let mut final_result: i64 = 0;

    //     let text = String::from(
    //         r"47|53
    // 97|13
    // 97|61
    // 97|47
    // 75|29
    // 61|13
    // 75|53
    // 29|13
    // 97|29
    // 53|29
    // 61|53
    // 97|53
    // 61|29
    // 47|13
    // 75|47
    // 97|75
    // 47|61
    // 75|61
    // 47|29
    // 75|13
    // 53|13
    //
    // 75,47,61,53,29
    // 97,61,53,29,13
    // 75,29,13
    // 75,97,47,61,53
    // 61,13,29
    // 97,13,75,29,47",
    //     );
    let rules_list_updates = get_rules_list_updates(text);

    let rules = rules_list_updates.0;

    println!("************************");
    for (key, values) in rules.clone() {
        println!("{key}\n");
        for value in values {
            println!("{value}");
        }
        println!("============================");
    }
    println!("************************");

    for list_update in rules_list_updates.1 {
        let mut is_succeded = true;
        let pages = list_update.split(",").collect::<Vec<&str>>();
        println!("{:?}", pages);
        for i in 0..pages.len() {
            println!("---------------------------");
            println!("{}", pages[i]);
            if rules.contains_key(pages[i]) {
                let rule_after_number = rules.get(pages[i]).unwrap().to_vec();
                for number_search in rule_after_number {
                    println!("{}", number_search);
                    let index_letter = pages.iter().position(|x| *x == number_search);
                    if let Some(index) = index_letter {
                        if index < i {
                            println!("{index} - {i}");
                            is_succeded = false;
                            break;
                        }
                    }
                }
            }
        }
        if is_succeded {
            let page = pages[pages.len() / 2].parse::<i64>().unwrap();
            final_result += page;
            println!("Pagina media succeded {}", page);
        }
    }

    final_result
}

fn resolve_part2() -> i64 {
    let text = get_text().unwrap();
    let mut final_result: i64 = 0;

    let text = String::from(
        r"47|53
97|13
97|61
97|47
75|29
61|13
75|53
29|13
97|29
53|29
61|53
97|53
61|29
47|13
75|47
97|75
47|61
75|61
47|29
75|13
53|13

75,47,61,53,29
97,61,53,29,13
75,29,13
75,97,47,61,53
61,13,29
97,13,75,29,47",
    );
    let rules_list_updates = get_rules_list_updates(text);

    let rules = rules_list_updates.0;

    println!("************************");
    for (key, values) in rules.clone() {
        println!("{key}\n");
        for value in values {
            println!("{value}");
        }
        println!("============================");
    }
    println!("************************");

    let mut incorrect_list_pages: Vec<String> = Vec::new();
    for list_update in rules_list_updates.1 {
        let mut is_succeded = true;
        let pages = list_update.split(",").collect::<Vec<&str>>();
        println!("{:?}", pages);
        for i in 0..pages.len() {
            println!("---------------------------");
            println!("{}", pages[i]);
            if rules.contains_key(pages[i]) {
                let rule_after_number = rules.get(pages[i]).unwrap().to_vec();
                for number_search in rule_after_number {
                    println!("{}", number_search);
                    let index_letter = pages.iter().position(|x| *x == number_search);
                    if let Some(index) = index_letter {
                        if index < i {
                            println!("{index} - {i}");
                            is_succeded = false;
                            break;
                        }
                    }
                }
            }
        }
        if !is_succeded {
            incorrect_list_pages.push(list_update);
        }
    }

    for incorrect_list_page in incorrect_list_pages {
        println!("{}", incorrect_list_page);
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

fn get_rules_list_updates(text: String) -> (HashMap<String, Vec<String>>, Vec<String>) {
    let mut rules: HashMap<String, Vec<String>> = HashMap::new();
    let pattern = r"(\d{1,4}\|\d{1,4})";
    let regex_rules = Regex::new(pattern).unwrap();

    let matches = regex_rules
        .find_iter(text.as_str())
        .map(|mat| mat.as_str())
        .collect::<Vec<&str>>();

    for rule in matches {
        println!("{}", rule);
        if !rule.is_empty() {
            let split_rule = rule.split("|").collect::<Vec<&str>>();
            if rules.contains_key(&split_rule[0].to_string()) {
                let mut values = rules.get(split_rule[0]).unwrap().to_vec();
                values.push(split_rule[1].to_string());
                rules.insert(split_rule[0].to_string(), values.to_vec());
            } else {
                let mut values: Vec<String> = Vec::new();
                values.push(String::from(split_rule[1]));
                rules.insert(split_rule[0].to_string(), values.to_vec());
            }
        }
    }

    let mut update_list: Vec<String> = Vec::new();
    let pattern = r"(\d{1,4}\|\d{1,4})";
    let regex_rules = Regex::new(pattern).unwrap();

    let non_matching: Vec<&str> = regex_rules
        .split(&text)
        .filter(|part| !part.trim().is_empty())
        .collect();

    for list in non_matching {
        for line in list.lines() {
            if !line.is_empty() {
                println!("{}", line);
                update_list.push(line.to_string());
            }
        }
    }

    (rules, update_list)
}
