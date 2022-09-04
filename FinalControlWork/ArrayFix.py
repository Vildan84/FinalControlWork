def FixArray(array):
    result = []
    for i in range(len(array)):
        if len(array[i]) <= 3:
            result.append(array[i])
    return result

print(FixArray(["apple", "dog", "station", "cat", "al", "up"]))