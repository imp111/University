def mixs(num):
    try:
        ele = int(num)
        return (0, ele, '')
    except ValueError:
        return (1, num, '')
#------------------------------------------------------------------------------------------------------------------------------

townList = ["Sofia", "Plovdiv", "Varna", 1243000, 668334, 471252]
print(townList[0], type(townList[0]))

print() #----------------------------------------------------------------------------------------------------------------------

lengthList = len(townList)
print(townList[lengthList - 2], type(townList[lengthList - 2]))

print() #----------------------------------------------------------------------------------------------------------------------

townList.insert(1, "Ruse")
lengthList = len(townList)
print("Length of list: {}".format(lengthList))

print() #----------------------------------------------------------------------------------------------------------------------

townList.insert(2, 218556)
lengthList = len(townList)
print("Length of list: {}".format(lengthList))

print() #----------------------------------------------------------------------------------------------------------------------

print("Before sorting: {}".format(townList)) #before sorting

print() #----------------------------------------------------------------------------------------------------------------------

sortedList = townList.copy()
sortedList.sort(key = mixs) #sort numbericly
print("After sorting: {}".format(sortedList)) #after sorting

print() #----------------------------------------------------------------------------------------------------------------------

joinedList = townList + sortedList
print("Before removal of Plovdiv: {}".format(joinedList))
lengthList = len(joinedList)
print("Length of list: {}".format(lengthList))

print() #----------------------------------------------------------------------------------------------------------------------

for i in joinedList:
    if (i == "Plovdiv"):
        joinedList.remove(i)

print("After removal of Plovdiv: {}".format(joinedList))
lengthList = len(joinedList)
print("Length of list: {}".format(lengthList))

