#a = [200, 130]
#b = [130]
#if sum(a) > sum(b):
#   a.sort()
#   b.sort()
#   temp = [int(i) for i in a]
#   i=0
#   while(sum(b) <= sum(temp)  and (i <= len(a) - 1)):
#      b.append(a[i])
#      temp.remove(a[i])
#      i = i+1

#a = [int(i) for i in temp]
#if sum(b) > sum(a):
#    a.sort()
#    b.sort()
#    temp = [int(i) for i in b]
#    i=0
#    while(sum(a) <= sum(temp)  and (i <= len(b) - 1)):
#        a.append(b[i])
#        temp.remove(b[i])
#        i = i+1        

#    b = [int(i) for i in temp]


#print (a)
#print (b)

from itertools import combinations
from collections import Counter

a = [70, 30, 33, 23, 4, 4, 34, 95]
b = [50, 10, 10, 7]

def balance(small, big):
    small.sort()
    big.sort()
    diff = sum(big) - sum(small)
    if diff < 0:
        small, big = big, small
    stack = {(0, 1)}  # each element is (# of elements to take from small, # of elements to take from big)
    while stack:
        i, j = sorted(stack, key=lambda t: t[0]+t[1]).pop(0)
        stack.remove((i, j))
        diff = sum(big) - sum(small)
        if i == 0:
            matches = [(Counter(), Counter(x)) for x in combinations(big, j) if diff - 2 * sum(x) == 0]
        else:
            matches = [(Counter(x), Counter(y)) for x in combinations(small, i) for y in combinations(big, j) if
                       diff - 2 * sum(y) + 2 * sum(x) == 0]
        if matches:
            return list((Counter(small) - matches[0][0] + matches[0][1]).elements()), \
                   list((Counter(big) - matches[0][1] + matches[0][0]).elements())
        else:
            if sum(big[-j:]) * 2 - sum(small[-i:]) > diff and i + 1 < len(small):
                stack.add((i + 1, j))
            if sum(big[:j]) * 2 - sum(small[:i]) < diff and j + 1 < len(big):
                stack.add((i, j + 1))
        return a,b


print(a,b)


