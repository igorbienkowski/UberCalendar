from tkinter import *

login_window = Tk()

label_email = Label(login_window, text="Email:")
label_password = Label(login_window, text="Password:")
entry_email = Entry(login_window)
entry_password = Entry(login_window)
login_button = Button(login_window, text="Log In")
register_button = Button(login_window, text="Register")
label_email.grid(row=2, column=2, sticky=W)
label_password.grid(row=2, column=3, sticky=W)
entry_email.grid(row=3, column=2)
entry_password.grid(row=3, column=3)
login_button.grid(row=4, columnspan=6)
register_button.grid(row=5, columnspan=6)

login_window.mainloop()