fd = open("export_EMSC.csv", "r")   #insert absolute path if file to open is not in the same folder 

lessThan2 = []
between2And3 = []
between3And4 = []
moreThan4 = []

for i in fd:
    x = i.split(";")

    if (x[7] == "Magnitude"):
        continue
    else:
        y = float(x[7])
    if (y < 2):
        lessThan2.append(i)
    elif (y >= 2 and y < 3):
        between2And3.append(i)
    elif (y >= 3 and y < 4):
        between3And4.append(i)
    else:
        moreThan4.append(i)
       

print("Less than 2: ")
for x in lessThan2:
    print(x, end='')

print()

print("Between 2 and 3: ")
for x in between2And3:
    print(x, end='')

print()

print("Between 3 and 4: ")
for x in between3And4:
    print(x, end='')

print()

print("More than 4: ")
for x in moreThan4:
    print(x, end='')

fd.close()  
