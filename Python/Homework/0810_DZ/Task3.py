# Напишите программу, которая принимает на вход координаты точки (X и Y),
# причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка (или на какой оси она находится).

# Пример:
# - x=34; y=-30 -> 4
# - x=2; y=4-> 1
# - x=-34; y=-30 -> 3

def quatter_detetction (X, Y):
    if (X > 0 and Y > 0):
        return 1
    elif (X < 0 and Y > 0):
        return 2
    elif (X < 0 and Y < 0):
        return 3
    elif (X > 0 and Y < 0):
        return 4
    else:
        return -1

first_number = int(input('Введите координаты точки X: '))
second_number = int(input('Введите координаты точки Y: '))
print(f'Номер четверти плоскости, в которой находится эта точка: {quatter_detetction (first_number, second_number)}')