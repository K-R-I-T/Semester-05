Alter table Artworks
add constraint DF_Artworks_released_date
default getdate() for released_date

Alter table Comments
add constraint DF_Comments_comment_time
default getdate() for comment_time

Alter table Notifications
add constraint DF_Notifications_notice_time
default getdate() for notice_time

Alter table Orders
add constraint DF_Orders_order_time
default getdate() for order_time

Alter table Reports
add constraint DF_Reports_report_time
default getdate() for report_time

Alter table Requests
add constraint DF_Requests_request_time
default getdate() for request_time

Alter table Responses
add constraint DF_Responses_response_time
default getdate() for response_time

Alter table Users
add constraint DF_Users_join_date
default getdate() for join_date