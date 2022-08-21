# Naruci.ba
# About
NaruciBa is a delivery app targeted for people that dont't have time or means to do their shopping chores. It allows users to craft a shopping list of items from a particular store and get those items delivered to them. The app consists of:
  - a flutter mobile app for users to make orders and for delivery staff to recieve assigned orders
  - a windows desktop app where a coordinator has insight in orders, delivery staff, shops and items being sold and is mainly used for assigning orders to delivery staff 
  - a main api server and a identity server for authorization
  - a main sql database and a identity server sql database

# Setup
Clone the repository and navigate to a folder "NaruciBa". Docker is needed in order to run the necessary api, identity server, sql and identity server sql containers.

### Intialize necessary docker containers
 ```
  docker-compose build
  docker-compose up
 ```
 After the docker containers have been initialized, we can run the desktop and mobile apps. Mobile app will need additional setup as it has to be run on a mobile emulator using flutter commands:
  ```
  flutter pub get
  flutter run --no-sound-null-safety
 ```
# Login info
There are 3 different user types: desktop user which logs in to a windows desktop app, and two mobile users which log in to a mobile app, one being a customer and the other being the delivery staff.
### Desktop user:
 ```
  email: desktop@gmail.com
  password: test
 ```
### Mobile user
 ```
  email: mobile@gmail.com
  password: test
 ```
### Dostavljac
 ```
  email: dostavljac@gmail.com
  password: test
 ```
 
# Overview
### Mobile app
- Customer uses the mobile app to create an account, search the available stores, select the products to be added in a basket, and finalize the order by either paying in person or usign a paypal service. The customer has insight into their past orders as well as the current active order and its current status.
- Delivery staff uses the mobile app to log into their account and have insight into the orders that they have been assigned, recieve the order and update its current status, upload an image of a receipt and have insight into the completed orders.

### Desktop app
- A coordinator uses the desktop app to add/edit the stores and store chains available as well as the items they offer, add/edit the delivery staff, add/edit the item categories ans subcategories, and assign free delivery personel to active orders.

### Notable features
- Identity server is used for user authorization and access token issuing
- Paypal payment option on mobile app when making an order
- SignalR enabling real-time order updates between the desktop and mobile app on
- Picture upload used by delivery staff to upload pictures of physical receipts if available

### Screenshots
![Screenshot_1](https://github.com/WeH1D/Naruci.ba/blob/main/Screenshots/Desktop.jpg)
![Screenshot_2](https://github.com/WeH1D/Naruci.ba/blob/main/Screenshots/mobile.jpg)


