# Создайте программу для игры с конфетами человек против человека.

# Условие задачи: На столе лежит 2021 конфета. Играют два игрока делая ход друг после друга.
# Первый ход определяется жеребьёвкой. За один ход можно забрать не более чем 28 конфет.
# Все конфеты оппонента достаются сделавшему последний ход.
# Сколько конфет нужно взять первому игроку, чтобы забрать все конфеты у своего конкурента?

# a) Добавьте игру против бота
# b) Подумайте как наделить бота "интеллектом"

import random

def change_player():
    if current_player == first_playername:
        return second_playername
    else:
        return first_playername

def check_amount(candy):
    if (candy < 1):
        print(f'[!] Вы должны взять хотя бы 1 конфету.')
        return False
    if (candy > 28):
        print(f'[!] Вы не можете взять более {max_candy_available} конфет.')
        return False
    if (candy > candy_amount):
        print(f'[!] Вы не можете взять более {candy_amount} конфет.')
        return False
    else:
        return True

candy_amount = 29 + 29 + 29
max_candy_available = 28
print(f'Первому игроку нужно взять {candy_amount - ((max_candy_available + 1) * (candy_amount // (max_candy_available + 1)))} конфет.')
print(f'На столе лежит {candy_amount} конфет(а). За один ход можно забрать не более чем {max_candy_available} конфет(ы).')
game_mode = int(input('Выберите режим:\n1 - PvP\n2 - PvE(random)\n3 - PvE(smart)\n'))

# PvP:
if game_mode == 1:
    first_playername = input('Имя первого игрока: ')
    second_playername = input('Имя второго игрока: ')
    current_player = random.choice([first_playername, second_playername])
    print(f'Первым ходит {current_player}')

    while True:
        candy_taken = int(input(f'{current_player}, осталось {candy_amount} конфет. Сколько возьмём? '))
        if not check_amount(candy_taken):
            continue
        candy_amount -= candy_taken
        if (candy_amount <= 0):
            break
        current_player = change_player()
    print(f'{current_player} победил!')

# PvE(random):
elif game_mode == 2:
    first_playername = input('Имя игрока: ')
    second_playername = 'PC'
    current_player = random.choice([first_playername, second_playername])
    print(f'Первым ходит {current_player}')

    while True:
        if current_player == 'PC':
            if candy_amount <= max_candy_available:
                candy_taken = candy_amount
            else:
                candy_taken = random.randint(1, max_candy_available)
            print(f'{current_player}, осталось {candy_amount} конфет. Сколько возьмём? {candy_taken}')
        else:
            candy_taken = int(input(f'{current_player}, осталось {candy_amount} конфет. Сколько возьмём? '))
        if not check_amount(candy_taken):
            continue
        candy_amount -= candy_taken
        if (candy_amount <= 0):
            break
        current_player = change_player()
    print(f'{current_player} победил!')

# PvE(smart):
elif game_mode == 3:
    first_playername = input('Имя игрока: ')
    second_playername = 'PC'
    current_player = random.choice([first_playername, second_playername])
    print(f'Первым ходит {current_player}')

    while True:
        if current_player == 'PC':
            if candy_amount <= max_candy_available:
                candy_taken = candy_amount
            else:
                candy_taken = candy_amount - (candy_amount // (max_candy_available + 1)) * (max_candy_available + 1)
                if (candy_taken == 0): candy_taken += 1
            print(f'{current_player}, осталось {candy_amount} конфет. Сколько возьмём? {candy_taken}')
        else:
            candy_taken = int(input(f'{current_player}, осталось {candy_amount} конфет. Сколько возьмём? '))
        if not check_amount(candy_taken):
            continue
        candy_amount -= candy_taken
        if (candy_amount <= 0):
            break
        current_player = change_player()
    print(f'{current_player} победил!')

else:
    print('Такого режима не существует.')
