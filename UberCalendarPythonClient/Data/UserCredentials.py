class UserCredentials:
    def __init__(self,email,password):
        self.email = email
        self.password = password

    def get_password(self):return self._password
    def set_password(self,password):self._password = password

    def get_email(self):return self._email
    def set_email(self,email):self._email = email

    password = property(get_password,set_password)
    email = property(get_email,set_email)





