from tkinter import *
from tkcalendar import *
from tkinter import ttk

add_event_window = Tk()
add_event_window.title("Add Event")
add_event_window.geometry("360x250")
add_event_window.resizable(0, 0)

date_entry = DateEntry(add_event_window,width=10,height=1)
type_combobox = ttk.Combobox(add_event_window, values=("Meeting","Call","Travel","Kids","Shopping"))
type_combobox.current(0)
description_entry = Text(add_event_window,width=34,height=10)
add_event_button = Button(add_event_window, text="Add Event", width=8)

date_entry.grid(row=0,sticky = "e",pady=(10,10), padx=(10,10))
type_combobox.grid(row=0,column=3,sticky = "w",padx=(10,10), pady=(10,10))
description_entry.grid(row=1,rowspan=8, columnspan=4, padx=10)
add_event_button.grid(row=9,column=1,columnspan=2,pady=(10,10))

add_event_window.mainloop()
