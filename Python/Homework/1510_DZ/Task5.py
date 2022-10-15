# Задайте число. Составьте список чисел Фибоначчи, в том числе для отрицательных индексов.

# Пример:
# для k = 8 список будет выглядеть так: [-21 ,13, -8, 5, −3, 2, −1, 1, 0, 1, 1, 2, 3, 5, 8, 13, 21]

def fibonacci(n):
    result_list = [0, 1]
    if (n == 0):
        return result_list[0]
    elif (n == 1):
        return result_list
    else:
        for i in range(2, n+1):
            result_list.append(result_list[i - 1] + result_list[i - 2])
        return result_list


def negafibonacci(n):
    result_list = [1, -1]
    if (n == 0):
        return 0
    elif (n == 1):
        result_list = [1]
        return result_list
    elif (n == 2):
        result_list.reverse()
        return result_list
    else:
        for i in range(2, n):
            result_list.append(result_list[i - 2] - result_list[i - 1])
        result_list.reverse()
        return result_list


user_num = int(input('Задайте натуральное число: '))
print(f'{negafibonacci(user_num) + fibonacci(user_num)} - числа Фибоначчи')
