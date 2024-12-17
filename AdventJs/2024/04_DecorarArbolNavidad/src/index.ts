function createXmasTree(height: number, ornament: string): string {
    if (!(height > 0 && height <= 100)) {
        return '';
    }

    // Por cada linea, se pintan 2 nuevos caracteres
    let weight = (height * 2) - 1;
    let returnXmasTree = ["_".repeat(weight)];
    const middleIndex = Math.round((weight / 2) - 1);

    for (let i = 0; i < height; i++) {
        let xMasTreeLine = returnXmasTree[i].split('');
        let middleCharacter = xMasTreeLine[middleIndex];

        if (middleCharacter != ornament) {
            xMasTreeLine[middleIndex] = ornament;
        } else {
            let firstOrnament = xMasTreeLine.indexOf(ornament);
            xMasTreeLine[firstOrnament - 1] = ornament;

            let lastOrnament = (xMasTreeLine.length) - firstOrnament;
            xMasTreeLine[lastOrnament] = ornament;
        }

        returnXmasTree[i] = xMasTreeLine.join('');

        if (i + 1 < height) {
            returnXmasTree[i + 1] = xMasTreeLine.join('');
        }
    }
    let lineToAdd = "_".repeat(weight).split('');
    lineToAdd[middleIndex] = "#";

    returnXmasTree[returnXmasTree.length] = lineToAdd.join('');
    returnXmasTree[returnXmasTree.length] = lineToAdd.join('');


    return returnXmasTree.join('\n');
}


const tree = createXmasTree(5, '*')
console.log(tree)
/*
____*____
___***___
__*****__
_*******_
*********
____#____
____#____
*/

const tree2 = createXmasTree(3, '+')
console.log(tree2)
/*
__+__
_+++_
+++++
__#__
__#__
*/

const tree3 = createXmasTree(6, '@')
console.log(tree3)
/*
_____@_____
____@@@____
___@@@@@___
__@@@@@@@__
_@@@@@@@@@_
@@@@@@@@@@@
_____#_____
_____#_____
*/