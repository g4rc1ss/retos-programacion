use std::{
    collections::HashMap, sync::{Arc, Mutex}, thread::{self, JoinHandle, Thread}
};

use regex::Regex;

pub fn frequency(input: &[&str], worker_count: usize) -> HashMap<char, usize> {
    let return_map = Mutex::new(HashMap::new());
    let mut handle = vec![];

    for text in input {
        if handle.len() < worker_count {
            let thread_handle = thread::spawn(move || {
                count_character(&text, &mut return_map.lock().unwrap());
            });
            handle.push(thread_handle);
        } else {
            count_character(&text, &mut return_map.lock().unwrap());
        }
    }

    for worker in handle {
        worker.join().unwrap();
    }

    HashMap::new()
}

fn count_character(text: &&str, return_map: &mut HashMap<char, usize>) {
    let lower_text = text.to_lowercase();
    'characters_for: for character in lower_text.chars() {
        let regex = Regex::new(r"(\s|,|\d)").unwrap();
        if regex.is_match(&character.to_string()) {
            continue 'characters_for;
        }
        if return_map.contains_key(&character) {
            if let Some(value) = return_map.get_mut(&character) {
                *value += 1;
            }
        } else {
            return_map.insert(character, 1);
        }
    }
}
