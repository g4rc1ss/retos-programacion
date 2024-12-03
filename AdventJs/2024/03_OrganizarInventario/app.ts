type Inventory = Array<
    { name: string, quantity: number, category: string }
>

function organizeInventory(inventory: Inventory): object {
    let response: Record<string, { [key: string]: number }> = {}
    inventory.forEach(element => {
        response[element.category] ??= {}

        if (response[element.category][element.name]) {
            response[element.category][element.name] += element.quantity
        } else {
            response[element.category][element.name] = element.quantity
        }
    });

    return response;
}



const inventary = [
    { name: 'doll', quantity: 5, category: 'toys' },
    { name: 'car', quantity: 3, category: 'toys' },
    { name: 'ball', quantity: 2, category: 'sports' },
    { name: 'car', quantity: 2, category: 'toys' },
    { name: 'racket', quantity: 4, category: 'sports' }
]
console.log(organizeInventory(inventary))

const inventary2 = [
    { name: 'book', quantity: 10, category: 'education' },
    { name: 'book', quantity: 5, category: 'education' },
    { name: 'paint', quantity: 3, category: 'art' }
]
console.log(organizeInventory(inventary2))

console.log(organizeInventory([{ name: "doll", quantity: 5, category: "toys" }]))

let inventary4 = [
    { name: "book", quantity: 10, category: "education" },
    { name: "book", quantity: 5, category: "education" },
    { name: "paint", quantity: 3, category: "art" }
];
console.log(organizeInventory(inventary4))

const inventary5 = [
    { name: "doll", quantity: 5, category: "toys" },
    { name: "car", quantity: 3, category: "toys" },
    { name: "ball", quantity: 2, category: "sports" },
    { name: "car", quantity: 2, category: "toys" },
    { name: "racket", quantity: 4, category: "sports" }
];
console.log(organizeInventory(inventary5))
