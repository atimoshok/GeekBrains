# Реализуйте RLE алгоритм: реализуйте модуль сжатия и восстановления данных.

def data_compression (input_string):
    count_symbol = 1
    previous_symbol = input_string[0]
    for symbol in input_string[1:]:
        if symbol == previous_symbol:
            count_symbol += 1
        else:
            print(f"{count_symbol}'{previous_symbol}'")
            previous_symbol = symbol
            count_symbol = 1
    print(f"{count_symbol}'{previous_symbol}'")

input_text = 'ffffffffffffaasdassssss   .....11111'
data_compression(input_text)
