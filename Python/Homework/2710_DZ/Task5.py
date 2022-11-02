# Даны два файла, в каждом из которых находится запись многочлена. Задача - сформировать файл, содержащий сумму многочленов.

with open(r'Python\Homework\2710_DZ\polinom1.txt', 'r') as f:
        simple_numbers = list(map(int, f.read().split()))