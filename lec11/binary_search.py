def Binary_Search(list,item):
    low = 0
    high = len(list)-1
    while low<=high:
        mid = (low + high)//2
        guess = list[mid]
        if guess == item:
            return mid
        if guess > item:
            high = mid -1
        else:
            low = mid +1
    return None
def fact(x):
    if x==1:
        return 1
    else:
        return x * fact(x-1)
my_list = [1,2,3,4,5,6,7,8,9,10]
print(Binary_Search(my_list,10))
print(Binary_Search(my_list,1))
print(fact(5))

