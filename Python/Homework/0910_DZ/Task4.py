# Задайте список из N элементов, заполненных числами из промежутка [-N, N].
# Найдите произведение элементов на указанных позициях.
# Позиции хранятся в файле file.txt в одной строке одно число.

input_num = int(input('Введите целоле число N: '))
lst = []
for i in range(-input_num, input_num + 1):
    lst.append(i)
print(lst)

with open(r'Python\Homework\0910_DZ\file.txt') as my_file:
    elem_pos = my_file.read().split()
print(f'Позиции из файла: {elem_pos}')

elem_multiply = 1
for i in elem_pos:
    elem_multiply *= lst[int(i)]
print(f'Произведение элементов на указанных позициях = {elem_multiply}')
