USE [PRN211_Project]
GO
/****** Object:  Table [dbo].[class]    Script Date: 3/21/2024 7:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[class](
	[class_id] [int] NOT NULL,
	[class_name] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[class_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[class_subject]    Script Date: 3/21/2024 7:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[class_subject](
	[subject_id] [varchar](255) NOT NULL,
	[class_id] [int] NOT NULL,
	[student_id] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[subject_id] ASC,
	[class_id] ASC,
	[student_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[exam]    Script Date: 3/21/2024 7:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[exam](
	[exam_id] [int] NOT NULL,
	[exam_name] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[exam_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[option]    Script Date: 3/21/2024 7:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[option](
	[question_id] [int] NULL,
	[option_content] [nvarchar](255) NULL,
	[right_answer] [bit] NULL,
	[option_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[option_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[question]    Script Date: 3/21/2024 7:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[question](
	[question_id] [int] NOT NULL,
	[question_content] [nvarchar](255) NULL,
	[subject_id] [varchar](255) NULL,
	[exam_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[question_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[role]    Script Date: 3/21/2024 7:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[role](
	[role_id] [int] NOT NULL,
	[role_name] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[subject]    Script Date: 3/21/2024 7:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[subject](
	[subject_id] [varchar](255) NOT NULL,
	[subject_name] [nvarchar](255) NULL,
PRIMARY KEY CLUSTERED 
(
	[subject_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[test]    Script Date: 3/21/2024 7:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[test](
	[test_id] [int] NOT NULL,
	[test_code] [varchar](255) NULL,
	[subject_id] [varchar](255) NULL,
	[exam_id] [int] NULL,
	[paper_no] [int] NULL,
	[status] [bit] NULL,
	[test_time] [int] NULL,
	[created_date] [datetime] NULL,
	[number_of_question] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[test_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[test_detail]    Script Date: 3/21/2024 7:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[test_detail](
	[question_id] [int] NOT NULL,
	[test_id] [int] NOT NULL,
	[option_choosen] [int] NULL,
	[user_id] [varchar](255) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[question_id] ASC,
	[test_id] ASC,
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 3/21/2024 7:43:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[user_id] [varchar](255) NOT NULL,
	[full_name] [nvarchar](255) NULL,
	[gender] [bit] NULL,
	[dob] [date] NULL,
	[email] [varchar](255) NULL,
	[password] [varchar](255) NULL,
	[role_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[class_subject]  WITH CHECK ADD FOREIGN KEY([class_id])
REFERENCES [dbo].[class] ([class_id])
GO
ALTER TABLE [dbo].[class_subject]  WITH CHECK ADD FOREIGN KEY([student_id])
REFERENCES [dbo].[user] ([user_id])
GO
ALTER TABLE [dbo].[class_subject]  WITH CHECK ADD FOREIGN KEY([subject_id])
REFERENCES [dbo].[subject] ([subject_id])
GO
ALTER TABLE [dbo].[option]  WITH CHECK ADD FOREIGN KEY([question_id])
REFERENCES [dbo].[question] ([question_id])
GO
ALTER TABLE [dbo].[question]  WITH CHECK ADD FOREIGN KEY([subject_id])
REFERENCES [dbo].[subject] ([subject_id])
GO
ALTER TABLE [dbo].[question]  WITH CHECK ADD  CONSTRAINT [FK_question_exam] FOREIGN KEY([exam_id])
REFERENCES [dbo].[exam] ([exam_id])
GO
ALTER TABLE [dbo].[question] CHECK CONSTRAINT [FK_question_exam]
GO
ALTER TABLE [dbo].[test]  WITH CHECK ADD FOREIGN KEY([exam_id])
REFERENCES [dbo].[exam] ([exam_id])
GO
ALTER TABLE [dbo].[test]  WITH CHECK ADD FOREIGN KEY([subject_id])
REFERENCES [dbo].[subject] ([subject_id])
GO
ALTER TABLE [dbo].[test_detail]  WITH CHECK ADD FOREIGN KEY([question_id])
REFERENCES [dbo].[question] ([question_id])
GO
ALTER TABLE [dbo].[test_detail]  WITH CHECK ADD FOREIGN KEY([test_id])
REFERENCES [dbo].[test] ([test_id])
GO
ALTER TABLE [dbo].[test_detail]  WITH CHECK ADD FOREIGN KEY([user_id])
REFERENCES [dbo].[user] ([user_id])
GO
ALTER TABLE [dbo].[user]  WITH CHECK ADD FOREIGN KEY([role_id])
REFERENCES [dbo].[role] ([role_id])
GO
