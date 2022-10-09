# first_number = int(input('Введите первое число: '))
# second_number = int(input('Введите второе число: '))
# print(f'Сумма = {first_number + second_number}')

# Найти максимальное из 5ти чисел
lst = []
for i in range(5):
    lst.append(int(input('Введите число ')))
print(lst)

max_value = lst[0]
for i in lst[1:]:
    if i > max_value: max_value = i
print(max_value)

print(max(lst))
