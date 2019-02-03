from tkinter import *
from tkcalendar import *
from tkinter import ttk

calendar_frame = Tk()
calendar_frame.title("Add Event")
calendar_frame.geometry("600x420")
calendar_frame.resizable(0, 0)

calendar = Calendar(calendar_frame,width=10,height=1)
add_event_button = Button(calendar_frame, text="Add event")
events_listbox = Listbox(calendar_frame,width=50,height=25)

calendar.grid(row=0,column=0,columnspan=4,rowspan = 4,pady=(10,10), padx=(10,10))
add_event_button.grid(row=4,sticky=N,column=1,columnspan=2,padx=(0,10), pady=(10,10))
events_listbox.grid(row=0,column=4,columnspan=4, rowspan=6, padx=(0,10), pady=10)

calendar_frame.mainloop()
