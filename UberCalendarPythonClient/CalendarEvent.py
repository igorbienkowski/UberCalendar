class CalendarEvent():

    def __init__(self):
        pass

    def __init__(self,id,description,user_id,date,time,type):
        self.id = id
        self.description = description
        self.user_id = user_id
        self.date = date
        self.time = time
        self.type = type

    def __str__(self):
        return f"An event with id:{str(self.id)} will occure at {self.time} on {self.date}. This is {self.type}. {self.description}."

    def get_id(self):
        return self._id
    def set_id(self,id):
        self._id = id

    def get_description(self):
        return self._description
    def set_description(self,desc):
        self._description = desc

    def get_user_id(self):
        return self._user_id
    def set_user_id(self,user_id):
        self._user_id = user_id

    def get_date(self):
        return self._date
    def set_date(self,date):
        self._date = date

    def get_time(self):
        return self._time
    def set_time(self,time):
        self._time = time

    def get_type(self):
        return self._type
    def set_type(self,type):
        self._type = type

    id = property(get_id,set_id)
    description = property(get_description,set_description)
    user_id = property(get_user_id,set_user_id)
    date = property(get_date,set_date)
    time = property(get_time,set_time)
    type = property(get_type,set_type)

event = CalendarEvent(7,"asdfasdf",22,"17/01/2019","17:23","Meeting")
print(event)

        
