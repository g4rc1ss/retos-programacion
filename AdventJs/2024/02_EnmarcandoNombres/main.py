def createFrame(names):
  lenght = 0
  
  for name in names:
    if len(name) > lenght:
      lenght = len(name)

#Se obtiene la longitud de la palabra mas larga y se suman 4 espacios
# Al inicio tiene que tener el * y luego el espacio de separacion y al final igual
  frame = "*" * (lenght + 4)
  returnFrame = frame

  for name in names:
    #Cogemos el largo del marco, restamos el de la palabra y agregamos espacios menos al final(-1) que agregamos un asterisco
    returnFrame = returnFrame + "\n" + "* " + name + (" " * (lenght - (len(name) - 1))) + "*"

  returnFrame = returnFrame + "\n" + frame
  return returnFrame


print(createFrame(['midu', 'madeval', 'educalvolpz']))
print(createFrame(['midu']))
print(createFrame(['a', 'bb', 'ccc']))
print(createFrame(['a', 'bb', 'ccc', 'dddd']))


