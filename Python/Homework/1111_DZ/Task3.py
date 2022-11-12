# Создайте программу для игры в "Крестики-нолики".

import random


def print_field():
    current_field = [[0, 0, 0], [0, 0, 0], [0, 0, 0]]
    for row in range(0, len(field)):
        for cal in range(0, len(field[row])):
            if field[row][cal] == 0:
                current_field[row][cal] = '-'
            elif field[row][cal] == 1:
                current_field[row][cal] = 'X'
            elif field[row][cal] == -1:
                current_field[row][cal] = 'O'
            print(current_field[row][cal], end=' ')
        print()


def change_player():
    if current_player == first_player:
        return second_player
    else:
        return first_player


def if_win():
    if sum(field[0][i] for i in range(0, len(field))) == (3 or -3): return True
    if sum(field[1][i] for i in range(0, len(field))) == (3 or -3): return True
    if sum(field[2][i] for i in range(0, len(field))) == (3 or -3): return True
    if sum(field[i][0] for i in range(0, len(field))) == (3 or -3): return True
    if sum(field[i][1] for i in range(0, len(field))) == (3 or -3): return True
    if sum(field[i][2] for i in range(0, len(field))) == (3 or -3): return True
    if sum(field[i][i] for i in range(0, len(field))) == (3 or -3): return True
    if sum(field[i][len(field)-1-i] for i in range(0, len(field))) == (3 or -3): return True
    return False


field = [[0, 0, 0], [0, 0, 0], [0, 0, 0]]
print_field()
first_player = 'X'
second_player = 'O'
current_player = random.choice([first_player, second_player])
print(f'Первым ходит {current_player}')
turn_counter = 1
while True:
    if turn_counter > len(field)**2:
        print('Ничья. Победила дружба :)')
        break
    else:
        current_row = int(input(f'{current_player}, Укажите ряд, в который хотите поставить символ (1-3): '))
        current_cal = int(input((f'{current_player}, Укажите столбец, в который хотите поставить символ (1-3): ')))
        if current_row < 1 or current_row > len(field) or current_cal < 1 or current_cal > len(field):
            print('[!] Вы вышли за границу поля.')
            continue
        if field[current_row - 1][current_cal - 1] != 0:
            print('[!] Эта ячейка уже занята, выберите другую.')
            continue
        else:
            if current_player == first_player:
                field[current_row - 1][current_cal - 1] = 1
            else:
                field[current_row - 1][current_cal - 1] = -1
            print_field()
            if if_win():
                print(f'Победил {current_player}')
                break
            current_player = change_player()
            turn_counter += 1
