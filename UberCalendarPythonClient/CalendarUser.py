class CalendarUser():
    def __init__(self):
        pass

    def __init__(self, id, name, surname, date_of_birth ):
        self.id = id
        self.name = name
        self.surname = surname
        self.date_of_birth = date_of_birth

    def __str__(self):
        return f"{self.name},{self.surname},{str(self.id)},{str(self.date_of_birth)}"

    def get_id(self):
        return self._id
    def set_id(self,id):
        self._id = id
    id = property(get_id,set_id)

    def get_name(self):
        return self._name
    def set_name(self,name):
        self._name = name
    name = property(get_name,set_name)

    def get_surname(self):
        return self._surname
    def set_surname(self,surname):
        self._surname = surname
    surname = property(get_surname,set_surname)

    def get_dob(self):
        return self._date_of_birth
    def set_dob(self,dob):
        self._date_of_birth = dob
    date_of_birth = property(get_dob,set_dob)
    


