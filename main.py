import pyautogui, time

f = open("beemovie", 'r')
for word in f:
    pyautogui.typewrite(word)
    pyautogui.press("enter")
