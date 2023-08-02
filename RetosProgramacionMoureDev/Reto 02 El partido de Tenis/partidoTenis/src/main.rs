use std::{collections::HashMap, io, vec};

fn main() {
    let mut secuenciaPuntos: Vec<String> = vec![];
    let mut isExit: bool = false;

    while !isExit {
        let option = menu();

        if option == String::new() {
            isExit = true;
        } else {
            secuenciaPuntos.push(option);
        }
    }

    recount(&mut secuenciaPuntos);
}

fn menu() -> String {
    let mut secuenciaTexto = String::new();
    print!(
        "Selecciona una opcion \n
    1) Player 1 \n
    2) Player 2 \n
    99) Exit \n"
    );

    io::stdin()
        .read_line(&mut secuenciaTexto)
        .expect("Error al leer el texto");

    secuenciaTexto = secuenciaTexto.trim().to_string();

    if secuenciaTexto == String::from("1") {
        return String::from("P1");
    } else if secuenciaTexto == String::from("2") {
        return String::from("P2");
    } else {
        return String::new();
    }
}

fn recount(secuenciaPuntos: &mut Vec<String>) {
    let mut player1Point = Point::new();
    let mut player2Point = Point::new();

    for punto in secuenciaPuntos {
        if punto.trim() == String::from("P1") {
            player1Point.add();
        } else {
            player2Point.add()
        }

        if player1Point.point == player2Point.point
            && (player1Point.point + player2Point.point) != 0
            && (player1Point.point + player2Point.point) >= 80
        {
            println!("Deuce");
        } else if player1Point.point > 40 || player2Point.point > 40 {
            if player1Point.point > player2Point.point {
                println!("Ventaja P1")
            } else if player2Point.point > player1Point.point {
                println!("Ventaja P2")
            }
            player1Point.point = 0;
            player2Point.point = 0;
        } else {
            println!(
                "{} - {}",
                player1Point.getPointName(),
                player2Point.getPointName()
            );
        }
    }

    println!("------------------------------------------");
    let mut ganador = String::new();
    if player1Point.add_number > player2Point.add_number {
        ganador = String::from("P1");
    } else {
        ganador = String::from("P2");
    }

    println!("Ha ganado el jugador {}", ganador);
}

struct Point {
    point: i32,
    add_number: i32,
    dictionaryPoint: HashMap<i32, String>,
}

impl Point {
    fn new() -> Point {
        Point {
            point: 0,
            add_number: 0,
            dictionaryPoint: [
                (0, String::from("Love")),
                (15, String::from("15")),
                (30, String::from("30")),
                (40, String::from("40")),
            ]
            .iter()
            .cloned()
            .collect(),
        }
    }

    fn add(&mut self) {
        if self.point == 0 {
            self.point = 15;
        } else if self.point == 15 {
            self.point = 30;
        } else if self.point == 30 {
            self.point = 40;
        } else if self.point == 40 {
            self.point = 99;
        } else {
            self.point = 0;
        }
        self.add_number += 1;
    }

    fn getPointName(&mut self) -> String {
        return self.dictionaryPoint.get(&self.point).unwrap().to_string();
    }
}
