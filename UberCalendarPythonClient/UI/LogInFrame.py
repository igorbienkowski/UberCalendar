from tkinter import *

login_window = Tk()
login_window.title("Log In")
login_window.geometry("200x140")
login_window.resizable(0, 0)

label_email = Label(login_window, text="Email:")
label_password = Label(login_window, text="Password:")
entry_email = Text(login_window,width=10,height=1)
entry_password = Text(login_window,width=10,height=1)
login_button = Button(login_window, text="Log In",width=8)
register_button = Button(login_window, text="Register",width=8)

label_email.grid(row=0,sticky = "w",pady=(10,0), padx=(10,0))
label_password.grid(row=0,column=1,sticky = "w",pady=(10,0))
entry_email.grid(row=1,padx=10,pady=(0,10))
entry_password.grid(row=1,column=1,padx=(0,10),pady=(0,10))
login_button.grid(row=2,columnspan=2,pady=(0,10))
register_button.grid(row=3,columnspan=2,pady=(0,10))

login_window.mainloop()