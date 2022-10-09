# Напишите программу, которая по заданному номеру четверти,
# показывает диапазон возможных координат точек в этой четверти (x и y).

def quatter_detetction (quatter_number):
    if (quatter_number == 1):
        print('X > 0 and Y > 0')
    elif (quatter_number == 2):
        print('X < 0 and Y > 0')
    elif (quatter_number == 3):
        print('X < 0 and Y < 0')
    elif (quatter_number == 4):
        print('X > 0 and Y < 0')
    else:
        print('Четверти на координатной плоскости с таким номером не существует')

user_number = int(input('Укажите номер четверти: '))
quatter_detetction(user_number)