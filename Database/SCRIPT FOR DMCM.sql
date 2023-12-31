USE [dmcm_api]
GO
/****** Object:  Table [dbo].[Customer_Details]    Script Date: 12-07-2023 15:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer_Details](
	[User_id] [varchar](25) NOT NULL,
	[Password] [varchar](25) NOT NULL,
	[Name] [varchar](75) NOT NULL,
	[Dob] [date] NOT NULL,
	[Address] [varchar](100) NOT NULL,
	[Mobile] [varchar](10) NOT NULL,
	[Email_id] [varchar](25) NULL,
PRIMARY KEY CLUSTERED 
(
	[User_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Doctor_Details]    Script Date: 12-07-2023 15:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Doctor_Details](
	[Doctor_id] [varchar](25) NOT NULL,
	[Password] [varchar](25) NOT NULL,
	[Name] [varchar](50) NOT NULL,
	[Dob] [date] NOT NULL,
	[Email_id] [varchar](50) NOT NULL,
	[License] [varchar](50) NOT NULL,
	[Specialization] [varchar](50) NULL,
	[Mobile] [varchar](10) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Doctor_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HealthPlan_Details]    Script Date: 12-07-2023 15:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HealthPlan_Details](
	[HealthPlan_id] [int] IDENTITY(1,1) NOT NULL,
	[HealthPlan_name] [varchar](25) NOT NULL,
	[Details] [varchar](900) NOT NULL,
	[HealthPlan_price] [decimal](10, 2) NOT NULL,
	[No_of_days] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[HealthPlan_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Insurance_Agent]    Script Date: 12-07-2023 15:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Insurance_Agent](
	[Agent_id] [varchar](25) NOT NULL,
	[Agent_Name] [varchar](25) NOT NULL,
	[Street_address] [varchar](25) NOT NULL,
	[Mobile_number] [varchar](10) NOT NULL,
	[City] [varchar](25) NOT NULL,
	[State] [varchar](25) NOT NULL,
	[Pincode] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Agent_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MedicareService_Details]    Script Date: 12-07-2023 15:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicareService_Details](
	[Service_id] [int] NULL,
	[Service_Name] [varchar](75) NOT NULL,
	[Service_Features] [varchar](75) NOT NULL,
	[Service_Benefits] [varchar](75) NOT NULL,
	[Service_Parameters] [varchar](75) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Service_Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MedicareService_master]    Script Date: 12-07-2023 15:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicareService_master](
	[Customer_registration_user_id] [varchar](25) NULL,
	[Service_id] [int] NOT NULL,
	[Service_Name] [varchar](25) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Service_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nomination_Details]    Script Date: 12-07-2023 15:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nomination_Details](
	[id] [int] IDENTITY(1000,1) NOT NULL,
	[Name] [varchar](25) NOT NULL,
	[Dob] [date] NOT NULL,
	[Email_id] [varchar](25) NOT NULL,
	[Mobile_number] [varchar](10) NOT NULL,
	[Country] [varchar](25) NOT NULL,
	[State] [varchar](30) NOT NULL,
	[City_name] [varchar](25) NOT NULL,
	[Pin_code] [int] NOT NULL,
	[Healthplan_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[view_reports]    Script Date: 12-07-2023 15:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[view_reports](
	[report_id] [varchar](25) NOT NULL,
	[customer_name] [varchar](25) NULL,
	[dob] [date] NULL,
	[email_id] [varchar](25) NULL,
	[mobile_number] [varchar](10) NULL,
	[doctor_name] [varchar](50) NULL,
	[diagnosis] [varchar](100) NULL,
	[result] [varchar](100) NULL,
	[nomination_details_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[report_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Customer_Details] ([User_id], [Password], [Name], [Dob], [Address], [Mobile], [Email_id]) VALUES (N'C001', N'password123', N'Neha Gupta', CAST(N'1992-08-15' AS Date), N'Chruch Street', N'9807654321', N'neha@example.com')
INSERT [dbo].[Customer_Details] ([User_id], [Password], [Name], [Dob], [Address], [Mobile], [Email_id]) VALUES (N'C002', N'securepass', N'Vijay Singh', CAST(N'1993-04-27' AS Date), N'MG ROAD', N'8807654321', N'vijay@example.com')
INSERT [dbo].[Customer_Details] ([User_id], [Password], [Name], [Dob], [Address], [Mobile], [Email_id]) VALUES (N'C003', N'anjali123', N'Anjali Mishra', CAST(N'1990-12-10' AS Date), N'BOMANNAHALI', N'7907654321', N'anjali@example.com')
INSERT [dbo].[Customer_Details] ([User_id], [Password], [Name], [Dob], [Address], [Mobile], [Email_id]) VALUES (N'C004', N'karan@123', N'Karan Sharma', CAST(N'1994-06-02' AS Date), N'MARATHALLI', N'9809954321', N'karan@example.com')
INSERT [dbo].[Customer_Details] ([User_id], [Password], [Name], [Dob], [Address], [Mobile], [Email_id]) VALUES (N'C005', N'pass1234', N'Preeti Patel', CAST(N'1991-03-18' AS Date), N'NAGAWARA', N'9807654333', N'preeti@example.com')
INSERT [dbo].[Customer_Details] ([User_id], [Password], [Name], [Dob], [Address], [Mobile], [Email_id]) VALUES (N'nimma001', N'das001', N'Nimmala Das', CAST(N'2001-12-24' AS Date), N'Manyata Tech Park', N'890220045', N'nimmla@das.com')
GO
INSERT [dbo].[Doctor_Details] ([Doctor_id], [Password], [Name], [Dob], [Email_id], [License], [Specialization], [Mobile]) VALUES (N'D001', N'password1', N'Dr. Rajesh Kumar', CAST(N'1990-05-15' AS Date), N'rajeshkumar@example.com', N'ABC123', N'Cardiology', N'9876543210')
INSERT [dbo].[Doctor_Details] ([Doctor_id], [Password], [Name], [Dob], [Email_id], [License], [Specialization], [Mobile]) VALUES (N'D002', N'password2', N'Dr. Priya Patel', CAST(N'1985-11-25' AS Date), N'priyapatel@example.com', N'DEF456', N'Dermatology', N'8765432109')
INSERT [dbo].[Doctor_Details] ([Doctor_id], [Password], [Name], [Dob], [Email_id], [License], [Specialization], [Mobile]) VALUES (N'D003', N'password3', N'Dr. Amit Sharma', CAST(N'1988-08-10' AS Date), N'amitsharma@example.com', N'GHI789', N'Orthopedics', N'7654321098')
INSERT [dbo].[Doctor_Details] ([Doctor_id], [Password], [Name], [Dob], [Email_id], [License], [Specialization], [Mobile]) VALUES (N'D004', N'password4', N'Dr. Neha Gupta', CAST(N'1992-02-03' AS Date), N'nehagupta@example.com', N'JKL012', N'Ophthalmology', N'6543210987')
INSERT [dbo].[Doctor_Details] ([Doctor_id], [Password], [Name], [Dob], [Email_id], [License], [Specialization], [Mobile]) VALUES (N'D005', N'password5', N'Dr. Sanjay Singh', CAST(N'1986-07-20' AS Date), N'sanjaysingh@example.com', N'MNO345', N'Pediatrics', N'5432109876')
INSERT [dbo].[Doctor_Details] ([Doctor_id], [Password], [Name], [Dob], [Email_id], [License], [Specialization], [Mobile]) VALUES (N'D006', N'docdoc', N'Dr.Ravi Gupta', CAST(N'2000-11-30' AS Date), N'ravi@gmail.com', N'NRFDA', N'Cardiology', N'7425087781')
GO
SET IDENTITY_INSERT [dbo].[HealthPlan_Details] ON 

INSERT [dbo].[HealthPlan_Details] ([HealthPlan_id], [HealthPlan_name], [Details], [HealthPlan_price], [No_of_days]) VALUES (1, N'Basic Plan', N'Covers basic medical expenses', CAST(100.00 AS Decimal(10, 2)), 30)
INSERT [dbo].[HealthPlan_Details] ([HealthPlan_id], [HealthPlan_name], [Details], [HealthPlan_price], [No_of_days]) VALUES (2, N'Silver Plan', N'Covers additional services and medications', CAST(200.00 AS Decimal(10, 2)), 60)
INSERT [dbo].[HealthPlan_Details] ([HealthPlan_id], [HealthPlan_name], [Details], [HealthPlan_price], [No_of_days]) VALUES (3, N'Gold Plan', N'Comprehensive coverage for major medical expenses', CAST(300.00 AS Decimal(10, 2)), 90)
INSERT [dbo].[HealthPlan_Details] ([HealthPlan_id], [HealthPlan_name], [Details], [HealthPlan_price], [No_of_days]) VALUES (4, N'Platinum Plan', N'Premium plan with extensive coverage and benefits', CAST(400.00 AS Decimal(10, 2)), 120)
INSERT [dbo].[HealthPlan_Details] ([HealthPlan_id], [HealthPlan_name], [Details], [HealthPlan_price], [No_of_days]) VALUES (5, N'Family Plan', N'Coverage for the whole family', CAST(500.00 AS Decimal(10, 2)), 365)
SET IDENTITY_INSERT [dbo].[HealthPlan_Details] OFF
GO
INSERT [dbo].[Insurance_Agent] ([Agent_id], [Agent_Name], [Street_address], [Mobile_number], [City], [State], [Pincode]) VALUES (N'1', N'Rahul Sharma', N'123 Street', N'9876543210', N'Mumbai', N'Maharashtra', 400001)
INSERT [dbo].[Insurance_Agent] ([Agent_id], [Agent_Name], [Street_address], [Mobile_number], [City], [State], [Pincode]) VALUES (N'2', N'Priya Patel', N'456 Street', N'8765432109', N'Delhi', N'Delhi', 110001)
INSERT [dbo].[Insurance_Agent] ([Agent_id], [Agent_Name], [Street_address], [Mobile_number], [City], [State], [Pincode]) VALUES (N'3', N'Amit Singh', N'789 Street', N'7654321098', N'Kolkata', N'West Bengal', 700001)
INSERT [dbo].[Insurance_Agent] ([Agent_id], [Agent_Name], [Street_address], [Mobile_number], [City], [State], [Pincode]) VALUES (N'4', N'Neha Gupta', N'321 Street', N'6543210987', N'Chennai', N'Tamil Nadu', 600001)
INSERT [dbo].[Insurance_Agent] ([Agent_id], [Agent_Name], [Street_address], [Mobile_number], [City], [State], [Pincode]) VALUES (N'5', N'Sanjay Kumar', N'654 Street', N'5432109876', N'Bangalore', N'Karnataka', 560001)
GO
INSERT [dbo].[MedicareService_Details] ([Service_id], [Service_Name], [Service_Features], [Service_Benefits], [Service_Parameters]) VALUES (3, N'Emergency Care', N'24/7 availability, critical care', N'Immediate medical attention in emergencies', N'Life-saving interventions, stabilization')
INSERT [dbo].[MedicareService_Details] ([Service_id], [Service_Name], [Service_Features], [Service_Benefits], [Service_Parameters]) VALUES (1, N'Health Checkup', N'Comprehensive examination and tests', N'Early detection of diseases, preventive care', N'Blood pressure, cholesterol, blood sugar levels')
INSERT [dbo].[MedicareService_Details] ([Service_id], [Service_Name], [Service_Features], [Service_Benefits], [Service_Parameters]) VALUES (4, N'Mental Health Counseling', N'Therapeutic sessions, counseling', N'Emotional support, coping strategies', N'Anxiety, depression, stress management')
INSERT [dbo].[MedicareService_Details] ([Service_id], [Service_Name], [Service_Features], [Service_Benefits], [Service_Parameters]) VALUES (2, N'Physical Therapy', N'Rehabilitation exercises, manual therapy', N'Improved mobility, pain management', N'Range of motion, strength assessment')
INSERT [dbo].[MedicareService_Details] ([Service_id], [Service_Name], [Service_Features], [Service_Benefits], [Service_Parameters]) VALUES (5, N'Surgical Procedures', N'Operative interventions, anesthesia', N'Treatment of diseases through surgery', N'Incision, anesthesia type')
GO
INSERT [dbo].[MedicareService_master] ([Customer_registration_user_id], [Service_id], [Service_Name]) VALUES (N'C001', 1, N'Health Checkup')
INSERT [dbo].[MedicareService_master] ([Customer_registration_user_id], [Service_id], [Service_Name]) VALUES (N'C002', 2, N'Physical Therapy')
INSERT [dbo].[MedicareService_master] ([Customer_registration_user_id], [Service_id], [Service_Name]) VALUES (N'C003', 3, N'Emergency Care')
INSERT [dbo].[MedicareService_master] ([Customer_registration_user_id], [Service_id], [Service_Name]) VALUES (N'C004', 4, N'Mental Health Counseling')
INSERT [dbo].[MedicareService_master] ([Customer_registration_user_id], [Service_id], [Service_Name]) VALUES (N'C005', 5, N'Surgical Procedures')
GO
SET IDENTITY_INSERT [dbo].[Nomination_Details] ON 

INSERT [dbo].[Nomination_Details] ([id], [Name], [Dob], [Email_id], [Mobile_number], [Country], [State], [City_name], [Pin_code], [Healthplan_id]) VALUES (1000, N'Rajesh Kumar', CAST(N'1990-05-15' AS Date), N'rajeshkumar@example.com', N'9876543210', N'India', N'Maharashtra', N'Mumbai', 400001, 1)
INSERT [dbo].[Nomination_Details] ([id], [Name], [Dob], [Email_id], [Mobile_number], [Country], [State], [City_name], [Pin_code], [Healthplan_id]) VALUES (1001, N'Priya Patel', CAST(N'1985-11-25' AS Date), N'priyapatel@example.com', N'8765432109', N'India', N'Delhi', N'Delhi', 110001, 2)
INSERT [dbo].[Nomination_Details] ([id], [Name], [Dob], [Email_id], [Mobile_number], [Country], [State], [City_name], [Pin_code], [Healthplan_id]) VALUES (1002, N'Amit Sharma', CAST(N'1988-08-10' AS Date), N'amitsharma@example.com', N'7654321098', N'India', N'West Bengal', N'Kolkata', 700001, 3)
INSERT [dbo].[Nomination_Details] ([id], [Name], [Dob], [Email_id], [Mobile_number], [Country], [State], [City_name], [Pin_code], [Healthplan_id]) VALUES (1003, N'Neha Gupta', CAST(N'1992-02-03' AS Date), N'nehagupta@example.com', N'6543210987', N'India', N'Tamil Nadu', N'Chennai', 600001, 4)
INSERT [dbo].[Nomination_Details] ([id], [Name], [Dob], [Email_id], [Mobile_number], [Country], [State], [City_name], [Pin_code], [Healthplan_id]) VALUES (1004, N'Sanjay Singh', CAST(N'1986-07-20' AS Date), N'sanjaysingh@example.com', N'5432109876', N'India', N'Karnataka', N'Bangalore', 560001, 5)
INSERT [dbo].[Nomination_Details] ([id], [Name], [Dob], [Email_id], [Mobile_number], [Country], [State], [City_name], [Pin_code], [Healthplan_id]) VALUES (1005, N'Rajesh Kumar', CAST(N'1990-05-15' AS Date), N'rajeshkumar@example.com', N'9876543210', N'India', N'Maharashtra', N'Mumbai', 400001, 1)
INSERT [dbo].[Nomination_Details] ([id], [Name], [Dob], [Email_id], [Mobile_number], [Country], [State], [City_name], [Pin_code], [Healthplan_id]) VALUES (1006, N'Priya Patel', CAST(N'1985-11-25' AS Date), N'priyapatel@example.com', N'8765432109', N'India', N'Delhi', N'Delhi', 110001, 2)
INSERT [dbo].[Nomination_Details] ([id], [Name], [Dob], [Email_id], [Mobile_number], [Country], [State], [City_name], [Pin_code], [Healthplan_id]) VALUES (1007, N'Amit Sharma', CAST(N'1988-08-10' AS Date), N'amitsharma@example.com', N'7654321098', N'India', N'West Bengal', N'Kolkata', 700001, 3)
INSERT [dbo].[Nomination_Details] ([id], [Name], [Dob], [Email_id], [Mobile_number], [Country], [State], [City_name], [Pin_code], [Healthplan_id]) VALUES (1008, N'Neha Gupta', CAST(N'1992-02-03' AS Date), N'nehagupta@example.com', N'6543210987', N'India', N'Tamil Nadu', N'Chennai', 600001, 4)
INSERT [dbo].[Nomination_Details] ([id], [Name], [Dob], [Email_id], [Mobile_number], [Country], [State], [City_name], [Pin_code], [Healthplan_id]) VALUES (1009, N'Sanjay Singh', CAST(N'1986-07-20' AS Date), N'sanjaysingh@example.com', N'5432109876', N'India', N'Karnataka', N'Bangalore', 560001, 5)
INSERT [dbo].[Nomination_Details] ([id], [Name], [Dob], [Email_id], [Mobile_number], [Country], [State], [City_name], [Pin_code], [Healthplan_id]) VALUES (1010, N'Ravi Kumar', CAST(N'2000-11-30' AS Date), N'ravi@example.com', N'8441991937', N'India', N'Karnataka', N'Bangalore', 560045, 2)
SET IDENTITY_INSERT [dbo].[Nomination_Details] OFF
GO
INSERT [dbo].[view_reports] ([report_id], [customer_name], [dob], [email_id], [mobile_number], [doctor_name], [diagnosis], [result], [nomination_details_id]) VALUES (N'1', N'Rajesh Kumar', CAST(N'1990-05-15' AS Date), N'rajeshkumar@example.com', N'9876543210', N'Dr. Rajesh Kumar', N'Diagnosis 1', N'Result 1', NULL)
INSERT [dbo].[view_reports] ([report_id], [customer_name], [dob], [email_id], [mobile_number], [doctor_name], [diagnosis], [result], [nomination_details_id]) VALUES (N'2', N'Priya Patel', CAST(N'1985-11-25' AS Date), N'priyapatel@example.com', N'8765432109', N'Dr. Priya Patel', N'Diagnosis 2', N'Result 2', 1001)
INSERT [dbo].[view_reports] ([report_id], [customer_name], [dob], [email_id], [mobile_number], [doctor_name], [diagnosis], [result], [nomination_details_id]) VALUES (N'3', N'Amit Sharma', CAST(N'1988-08-10' AS Date), N'amitsharma@example.com', N'7654321098', N'Dr. Amit Sharma', N'Diagnosis 3', N'Result 3', 1002)
INSERT [dbo].[view_reports] ([report_id], [customer_name], [dob], [email_id], [mobile_number], [doctor_name], [diagnosis], [result], [nomination_details_id]) VALUES (N'4', N'Neha Gupta', CAST(N'1992-02-03' AS Date), N'nehagupta@example.com', N'6543210987', N'Dr. Neha Gupta', N'Diagnosis 4', N'Result 4', 1003)
INSERT [dbo].[view_reports] ([report_id], [customer_name], [dob], [email_id], [mobile_number], [doctor_name], [diagnosis], [result], [nomination_details_id]) VALUES (N'5', N'Sanjay Singh', CAST(N'1986-07-20' AS Date), N'sanjaysingh@example.com', N'5432109876', N'Dr. Sanjay Singh', N'Diagnosis 5', N'Result 5', 1004)
GO
ALTER TABLE [dbo].[MedicareService_Details]  WITH CHECK ADD  CONSTRAINT [FK_SERVICE] FOREIGN KEY([Service_id])
REFERENCES [dbo].[MedicareService_master] ([Service_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MedicareService_Details] CHECK CONSTRAINT [FK_SERVICE]
GO
ALTER TABLE [dbo].[MedicareService_master]  WITH CHECK ADD  CONSTRAINT [FK_customer] FOREIGN KEY([Customer_registration_user_id])
REFERENCES [dbo].[Customer_Details] ([User_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[MedicareService_master] CHECK CONSTRAINT [FK_customer]
GO
ALTER TABLE [dbo].[Nomination_Details]  WITH CHECK ADD  CONSTRAINT [FK_NOMINATION] FOREIGN KEY([Healthplan_id])
REFERENCES [dbo].[HealthPlan_Details] ([HealthPlan_id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Nomination_Details] CHECK CONSTRAINT [FK_NOMINATION]
GO
ALTER TABLE [dbo].[view_reports]  WITH CHECK ADD  CONSTRAINT [fk_nomination_details] FOREIGN KEY([nomination_details_id])
REFERENCES [dbo].[Nomination_Details] ([id])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[view_reports] CHECK CONSTRAINT [fk_nomination_details]
GO
/****** Object:  StoredProcedure [dbo].[GetHealthPlanDetails]    Script Date: 12-07-2023 15:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[GetHealthPlanDetails] 
@PlanName varchar(25)
AS
BEGIN

SELECT * FROM HealthPlan_Details WHERE HealthPlan_name = @PlanName
END; 

GO
/****** Object:  StoredProcedure [dbo].[GetHealthPlanNames]    Script Date: 12-07-2023 15:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetHealthPlanNames]
AS
BEGIN
Select HealthPlan_name from HealthPlan_Details
END;
GO
/****** Object:  StoredProcedure [dbo].[GetInsuranceAgent]    Script Date: 12-07-2023 15:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetInsuranceAgent]
AS
BEGIN
SELECT * FROM Insurance_Agent
END
GO
/****** Object:  StoredProcedure [dbo].[GetMedicareServiceDetails]    Script Date: 12-07-2023 15:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetMedicareServiceDetails] 
@PlanName varchar(25)
AS
BEGIN

SELECT * FROM medicareservice_details WHERE Service_Name = @PlanName
END;
GO
/****** Object:  StoredProcedure [dbo].[GetMedicareServiceNames]    Script Date: 12-07-2023 15:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetMedicareServiceNames]
AS
BEGIN
Select Service_Name from medicareservice_details
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertCustomerDetails]    Script Date: 12-07-2023 15:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertCustomerDetails](
@User_id VARCHAR(25),
@Name VARCHAR(75),
@Password VARCHAR(25),
@Dob DATE,
@Email_id VARCHAR(25),
@Mobile VARCHAR(10),
@Address VARCHAR(100)
)
AS
BEGIN
-- Insert the new customer details into the table
INSERT INTO Customer_Details (User_id, Name, Password, Dob, Email_id,Mobile,Address)
VALUES (@User_id, @Name, @Password, @Dob, @Email_id,@Mobile,@Address)
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertDoctorDetails]    Script Date: 12-07-2023 15:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertDoctorDetails](
@Doctor_id VARCHAR(25),
@Password VARCHAR(25),
@Name VARCHAR(50),
@Dob DATE,
@Email_id VARCHAR(50),
@License VARCHAR(50),
@Specialization VARCHAR(50),
@Mobile varchar(10)
)
AS
BEGIN
-- Insert the new doctor details into the table
INSERT INTO Doctor_Details (Doctor_id, Password, Name, Dob, Email_id, License, Specialization, Mobile)
VALUES (@Doctor_id, @Password, @Name, @Dob, @Email_id, @License, @Specialization, @Mobile)
END;
GO
/****** Object:  StoredProcedure [dbo].[InsertNominationDetails]    Script Date: 12-07-2023 15:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertNominationDetails](

@Name VARCHAR(25),

@Dob DATE,

@Email_id VARCHAR(25),

@Mobile_number varchar(10),

@Country VARCHAR(25),

@State VARCHAR(30),

@City_name VARCHAR(25),

@Pin_code INT,

@Healthplan_id INT

)

AS

BEGIN

-- Insert the new nomination details into the table

INSERT INTO Nomination_Details (Name, Dob, Email_id, Mobile_number, Country, State, City_name, Pin_code, Healthplan_id)

VALUES (@Name, @Dob, @Email_id, @Mobile_number, @Country, @State, @City_name, @Pin_code, @Healthplan_id)

END;
GO
/****** Object:  StoredProcedure [dbo].[ViewReports]    Script Date: 12-07-2023 15:41:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ViewReports]
AS
BEGIN
SELECT * FROM view_reports
END
GO
