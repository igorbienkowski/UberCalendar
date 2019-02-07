import requests
import json
import datetime
from Data.CalendarUser import CalendarUser
from Data.CalendarEvent import CalendarEvent

class WebApiDataHandler():
    def __init__(self):
        base_adress_port = 8080
        self.url = "http://localhost:" + str(base_adress_port) + "/UberCalendar/"
        iis_port = 8080
        test_port = 50925

    def CredentialsCheck(self,credentials):
        credentialsDictionary = { "Email": credentials.email, "Password": credentials.password}
        data = json.dumps(credentialsDictionary)
        request = requests.post(self.url + "GetUser",json = data)
        user_dictionary = dict(request.json())
        user  = CalendarUser(user_dictionary["UserID"],user_dictionary["Name"],user_dictionary["Surname"],user_dictionary["DateOfBirth"])
        return user

    def GetEvents(self,dateForEvents,userId):
        paramsForEvents = {"dateForEvents":str(dateForEvents), "loggedInUser":userId}
        testUrl = self.url + "GetEventsForUser?date=" + str(dateForEvents) + "&userId=" + str(userId)
        request = requests.get(testUrl)
        listOfEvents = list(request.json())
        events = list()
        for object in listOfEvents:
            events.append(CalendarEvent(object["Id"],object["Description"],object["UserId"],object["Date"],object["Time"],object["Type"]))
        return events

    def RegisterUser(self,userToRegister,credentialsToRegister):
        registerDictionary = {
            "Email": credentialsToRegister.email,
            "Password": credentialsToRegister.password,
            "Name": userToRegister.name,
            "Surname": userToRegister.surname,
            "DateOfBirth": userToRegister.date_of_birth}
        data = json.dumps(registerDictionary)
        request = requests.post(self.url + "RegisterUser", json = data)
        response = request.status_code
        print(response)

    def AddEvent(self,eventToAdd):
        eventDictionary = { "Description": eventToAdd.description, "userId": eventToAdd.user_id, "date": eventToAdd.date, "time": eventToAdd.time, "type": eventToAdd.type }
        data = json.dumps(eventDictionary)
        request = requests.post(self.url + "PostEvent",json=data)
        response = request.status_code

test = WebApiDataHandler()
dateTest = str(datetime.datetime(2019,1,30).date()) 
userIdTest = 29
test.GetEvents(dateTest,userIdTest)



