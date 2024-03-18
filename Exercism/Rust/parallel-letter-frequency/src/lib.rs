use std::{
    collections::HashMap,
    sync::{Arc, Mutex},
    thread::{self},
};

use regex::Regex;

pub fn frequency(input: &[&str], worker_count: usize) -> HashMap<char, usize> {
    let return_map = Arc::new(Mutex::new(HashMap::new()));
    let mut handle = vec![];

    for text in input {
        let return_map_clone = Arc::clone(&return_map);
        let text = (*text).to_string();

        if handle.len() < worker_count {
            let thread_handle = thread::spawn(move || {
                count_character(&text, &mut return_map_clone.lock().unwrap());
            });
            handle.push(thread_handle);
        } else {
            count_character(&text, &mut return_map.lock().unwrap());
        }
    }

    for worker in handle {
        worker.join().unwrap();
    }

    let return_map: HashMap<char, usize> = return_map.lock().unwrap().clone();
    return_map
}

fn count_character(text: &str, return_map: &mut HashMap<char, usize>) {
    let lower_text = text.to_lowercase();
    'characters_for: for character in lower_text.chars() {
        let regex = Regex::new(r"(\s|,|\d)").unwrap();
        if regex.is_match(&character.to_string()) {
            continue 'characters_for;
        }
        *return_map.entry(character).or_insert(0) += 1;
    }
}
