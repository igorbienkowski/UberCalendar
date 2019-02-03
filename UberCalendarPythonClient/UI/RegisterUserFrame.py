from tkinter import *
from calendar import *
from tkcalendar import Calendar, DateEntry

register_window = Tk()
register_window.title("Register User")
register_window.geometry("250x260")
register_window.resizable(0, 0)

label_name = Label(register_window, text="Name:")
label_surname = Label(register_window, text="Surname:")
label_DOB = Label(register_window, text="Date of birth:")
label_email = Label(register_window, text="Email:")
label_email2 = Label(register_window, text="Repeat Email:")
label_password = Label(register_window, text="Password:")
label_password2 = Label(register_window, text="Reapeat Password")

entry_name = Text(register_window,width=10,height=1)
entry_surname = Text(register_window,width=10,height=1)
entry_DOB = DateEntry(register_window,width=11,height=1)
entry_email = Text(register_window,width=10,height=1)
entry_email2 = Text(register_window,width=10,height=1)
entry_password = Text(register_window,width=10,height=1)
entry_password2 = Text(register_window,width=10,height=1)

register_button = Button(register_window, text="Register",width=8)
back_button = Button(register_window, text="Back",width=8)

label_name.grid(row=0,column=0,sticky="e",pady=(10,10),padx=(10,10))
label_surname.grid(row=1,column=0,sticky="e",pady=(0,10),padx=(0,10))
label_DOB.grid(row=2,column=0,sticky="e",pady=(0,10),padx=(0,10))
label_email.grid(row=3,column=0,sticky="e",pady=(0,10),padx=(0,10))
label_email2.grid(row=4,column=0,sticky="e",pady=(0,10),padx=(0,10))
label_password.grid(row=5,column=0,sticky="e",pady=(0,10),padx=(0,10))
label_password2.grid(row=6,column=0,sticky="e",pady=(0,10),padx=(10,10))

entry_name.grid(row=0,column=1,sticky="e",pady=(10,10),padx=(0,10))
entry_surname.grid(row=1,column=1,sticky="e",pady=(0,10),padx=(0,10))
entry_DOB.grid(row=2,column=1,sticky="e",pady=(0,10),padx=(0,10))
entry_email.grid(row=3,column=1,sticky="e",pady=(0,10),padx=(0,10))
entry_email2.grid(row=4,column=1,sticky="e",pady=(0,10),padx=(0,10))
entry_password.grid(row=5,column=1,sticky="e",pady=(0,10),padx=(0,10))
entry_password2.grid(row=6,column=1,sticky="e",pady=(0,10),padx=(0,10))

register_button.grid(row=7,column=1,sticky="e",pady=(0,10),padx=(10,10))
back_button.grid(row=7,column=0,sticky="e",pady=(0,10),padx=(0,10))

register_window.mainloop()
