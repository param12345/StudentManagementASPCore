SET IDENTITY_INSERT [dbo].[Course] ON
INSERT INTO [dbo].[Course] ([Id], [course_Name], [start_date], [end_date], [course_duration]) VALUES (1, N'Web Level 5', N'2021-01-01 08:00:00', N'2021-09-30 16:00:00', N'9')
SET IDENTITY_INSERT [dbo].[Course] OFF
SET IDENTITY_INSERT [dbo].[Student] ON
INSERT INTO [dbo].[Student] ([Id], [student_Name], [student_Email], [student_Mobile], [student_Address], [CourseId]) VALUES (1, N'Ramu kaka', N'ramukaka@gmail.com', N'78906789', N'6789', 1)
SET IDENTITY_INSERT [dbo].[Student] OFF
INSERT INTO [dbo].[Student] ([Id], [student_Name], [student_Email], [student_Mobile], [student_Address], [CourseId]) VALUES (2, N'shamu', N'shamu@gmail.com', N'656667676', N'546', 2)
SET IDENTITY_INSERT [dbo].[Student] OFF

