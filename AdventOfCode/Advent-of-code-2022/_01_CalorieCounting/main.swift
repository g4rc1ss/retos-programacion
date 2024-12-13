//
//  main.swift
//  Year2022.Day01.CalorieCounting
//
//  Created by Asier Garcia Barrenengoa on 24/1/23.
//

import Foundation

let path: String = Bundle.main.resourcePath! + "/1Exercise"
let text = try String(contentsOfFile: path, encoding: .utf8).components(separatedBy: CharacterSet.newlines)

let totalCaloriasElfos = getTotalCaloriasElfos(text: text)

// -------------------------- PRIMER EJERCICIO ------------------------- \\

print("Primera respuesta: \(totalCaloriasElfos.max() ?? 0)")


// -------------------------- SEGUNDO EJERCICIO ------------------------- \\
let sumTresElfos = totalCaloriasElfos[0] + totalCaloriasElfos[1] + totalCaloriasElfos[2]
print("Primera respuesta: \(sumTresElfos)")







func getTotalCaloriasElfos(text:Array<String>) -> Array<Int64>{
    var calorias : Array<Int64> = [0]
    var caloriasIndex: Int = 0
    
    for word in text{
        if word.isEmpty{
            caloriasIndex += 1
            calorias.append(0)
        }
        else{
            calorias[caloriasIndex] += Int64(word) ?? 0
        }
    }
    calorias.sort(by: >)
    return calorias
}
