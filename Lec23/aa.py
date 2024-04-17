def Convert_seconds(seconds):
    minutes = seconds//60
    seconds %= 60 
    hours = minutes//60
    minutes %= 60 
    days = hours//24
    hours %= 24
    return hours,days,minutes,seconds
seconds = int(input("Enter Seconds "))
hours,days,minutes,seconds = Convert_seconds(seconds)


print("days",days)
print("Hours",hours)
print("Minutes",minutes)
print("seconds",seconds)

    