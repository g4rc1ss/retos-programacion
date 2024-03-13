pub fn reverse(input: &str) -> String {
    let mut return_string = String::new();

    for character in input.to_string().chars().rev() {
        return_string.push(character);
    }
    return_string
}
