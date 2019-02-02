class UserCredentials:
    def get_password(self):return self.password
    def set_password(self,password):self.password = password

    def get_email(self):return self.email
    def set_email(self,email):self.email = email

    password = property(get_password,set_password)
    email = property(get_email,set_email)



