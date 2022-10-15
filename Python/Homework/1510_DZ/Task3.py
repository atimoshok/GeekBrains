# Задайте список из вещественных чисел. Напишите программу, 
# которая найдёт разницу между максимальным и минимальным значением дробной части элементов.

# Пример:
# - [1.1, 1.2, 3.1, 5, 10.01] => 0.19

def fractional_part(elem):
    return round(elem - int(elem), 2)

lst = [1.1, 1.2, 3.1, 5, 10.01]
result_list = []

for i in range(len(lst)):
    if type(lst[i]) == float:
        result_list.append(fractional_part(lst[i]))

print(lst)
#print(result_list)
print(f'Разница между максимальным и минимальным значением дробной части элементов = {max(result_list) - min(result_list)}')
