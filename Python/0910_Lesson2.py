# # Напишите программу, которая принимает на вход число N и выдаёт последовательность из N членов.
# import random

# N = int(input('Введите натуральнное число N: '))
# for i in range(N):
#     print(random.randint(1, 10), end = " ")
# print()

# lst = []
# for i in range(N):
#     lst.append(random.randint(1, 10))
# print(lst)

# # Для N = 5: 1, -3, 9, -27, 81 и т.д.
# for i in range(N):
#     print((-3)**i, end = " ")

# 13.	Пользователь задаёт две строки. Определить количество вхождений одной строки в другой.

str1 = input('Введите первую строку: ')
str2 = input('Введите вторую строку: ')

if str2 in str1:
    print('Входит')
else:
    print('Такаой строки нет')

count_contains = 0
while str2 in str1:
    count_contains += 1
    elem_index_contain = str1.find(str2)
    #print(str1.find(str2))
    str1 = str1[elem_index_contain + len(str2):]
    #print(str1)

print(count_contains)