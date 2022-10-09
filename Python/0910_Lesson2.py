# Напишите программу, которая принимает на вход число N и выдаёт последовательность из N членов.
import random

N = int(input('Введите натуральнное число N: '))
for i in range(N):
    print(random.randint(1, 10), end = " ")
print()

lst = []
for i in range(N):
    lst.append(random.randint(1, 10))
print(lst)

# Для N = 5: 1, -3, 9, -27, 81 и т.д.
for i in range(N):
    print((-3)**i, end = " ")