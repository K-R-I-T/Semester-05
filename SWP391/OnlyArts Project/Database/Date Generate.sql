ALTER TABLE Orders
ADD CONSTRAINT DF_Orders_order_time
DEFAULT GETDATE() FOR order_time;
GO

ALTER TABLE Artworks
ADD CONSTRAINT DF_Artworks_released_date
DEFAULT GETDATE() FOR released_date;
GO

ALTER TABLE Comments
ADD CONSTRAINT DF_Comments_comment_time
DEFAULT GETDATE() FOR comment_time;
GO

ALTER TABLE Notifications
ADD CONSTRAINT DF_Notifications_notice_time
DEFAULT GETDATE() FOR notice_time;
GO

ALTER TABLE Reports
ADD CONSTRAINT DF_Reports_report_time
DEFAULT GETDATE() FOR report_time;
GO

ALTER TABLE Requests
ADD CONSTRAINT DF_Requests_request_time
DEFAULT GETDATE() FOR request_time;
GO

ALTER TABLE Responses
ADD CONSTRAINT DF_Responses_response_time
DEFAULT GETDATE() FOR response_time;
GO

ALTER TABLE Users
ADD CONSTRAINT DF_Users_join_date
DEFAULT GETDATE() FOR join_date;
GO
