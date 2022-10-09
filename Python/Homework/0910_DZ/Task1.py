# Напишите программу, которая принимает на вход вещественное число и показывает сумму его цифр.

# Пример:
# - 6782 -> 23
# - 0,56 -> 11

user_number = input('Введите вещественное число: ')
sum_elem = 0
for elem in user_number:
    if elem != ',' and elem != '.':
        sum_elem += int(elem)
print(f'Сумма цифр числа = {sum_elem}')
