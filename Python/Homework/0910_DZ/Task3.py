# Задайте список из n чисел последовательности (1+1/n)^n и выведите на экран их сумму.

# Пример:
# Для n = 4: {1: 2, 2: 2.25, 3: 2.37, 4: 2.44}

input_num = int(input('Введите целоле число N: '))
num_product = {}
for i in range(1, input_num + 1):
    num_product[i] = round((1 + (1 / i))**i, 2)
print(num_product)
