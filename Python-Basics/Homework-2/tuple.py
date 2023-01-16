def mixs(num):
    try:
        ele = int(num)
        return (0, ele, '')
    except ValueError:
        return (1, num, '')

townTuple = ("Sofia", "Plovdiv", "Varna")

townList = list(townTuple)
townList.append("Ruse")
townList[0] = 6486032
townTuple = tuple(townList)

numberTuple = (1243000, 668334, 471252)

joinedTuple = townTuple + numberTuple

joinedList = list(joinedTuple)
joinedList.sort(key = mixs)
joinedTuple = tuple(joinedList)
print(joinedTuple)

countInt = 0
for i in joinedTuple:
    if (type(i) == type(countInt)):
        countInt = countInt + 1
    
(strings) = joinedTuple[countInt:]
(ints) = joinedTuple[0:countInt]

print("Ints: {}".format(ints))
print("Strings: {}".format(strings))