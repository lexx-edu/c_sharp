from numpy import random
from collections import Counter


def create_array(frm, to, capacity):
    res = []
    for i in range(capacity):
        res.append(random.randint(frm, to+1))
    return res


def intersect(X, Y, x, y, position=0):
    intersection = False
    for i in range(position, len(X)):
        if X[i]==x and Y[i]==y:
            intersection = True
            break
    return intersection


def steps(coordinate):
    res = []
    for i in range(1, 9):
        res.append(i-coordinate)
    return res


def split_list(array, value=0):
    return array[:array.index(value)], array[array.index(value)+1:]


def list_alligment(list_1, list_2):
    len_1 = len(list_1)
    len_2 = len(list_2)
    if len_1 > len_2:
        list_1 = list_1[:len_2]
    elif len_1 < len_2:
        list_2 = list_2[:len_1]
    return list_1, list_2


def diagonal_matrix(x_steps, y_steps):
    left, right = split_list(x_steps)
    down, up = split_list(y_steps)

    left_up = list_alligment(left[::-1], up)
    left_down = list_alligment(left[::-1], down[::-1])
    right_up = list_alligment(right, up)
    right_down = list_alligment(right, down[::-1])
    return left_up, left_down, right_up, right_down


def battle(X, Y, x, y, position=0):
    if Counter(X)[x] > 1 or Counter(Y)[y] > 1:
        return True
    steps_offset = diagonal_matrix(steps(x), steps(y))
    for step in steps_offset:
        for n, _ in enumerate(step[0]):
            x_offset = x + step[0][n]
            y_offset = y + step[1][n]
            if intersect(X, Y, x_offset, y_offset, position):
                return True
    return False


intersection = True

while (intersection):
    intersection = False
    X = create_array(1, 8, 8)
    Y = create_array(1, 8, 8)
    for i in range(len(X)):
        if intersect(X, Y, X[i], Y[i], i + 1):
            intersection = True
            break

print(X)
print(Y)
print()

for i in range(len(X)):
    if battle(X, Y, X[i], Y[i], i + 1):
        print('YES')
        break
else:
    print('NO')
    