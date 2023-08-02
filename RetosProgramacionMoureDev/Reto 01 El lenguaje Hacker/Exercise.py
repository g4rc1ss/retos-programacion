diccionario = {
    'A': '4',
    'B': 'I3',
    'C': '[',
    'D': ')',
    'E': '3',
    'F': '|=',
    'G': '&',
    'H': '#',
    'I': '1',
    'J': ',_|',
    'K': '>|',
    'L': '1',
    'M': '/\\/\\',
    'N': '^/',
    'O': '0',
    'P': '|*',
    'Q': '(_,)',
    'R': 'I2',
    'S': '5',
    'T': '7',
    'U': '(_)',
    'V': '\/',
    'W': '\/\/',
    'X': '><',
    'Y': 'j',
    'Z': '2',
    }

text = input('Inserta la frase \n')
transformText = ''

for character in text:
    if character.upper() in diccionario:
        transformText += diccionario[character.upper()]
    else:
        transformText += character
        
print(transformText)