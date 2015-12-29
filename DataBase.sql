USE [master]
GO
/****** Object:  Database [BudgiDeskDB]    Script Date: 12/29/2015 6:48:17 AM ******/
CREATE DATABASE [BudgiDeskDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BudgiDeskDB', FILENAME = N'G:\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\BudgiDeskDB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'BudgiDeskDB_log', FILENAME = N'G:\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\BudgiDeskDB_log.ldf' , SIZE = 3456KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [BudgiDeskDB] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BudgiDeskDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BudgiDeskDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BudgiDeskDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BudgiDeskDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BudgiDeskDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BudgiDeskDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [BudgiDeskDB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BudgiDeskDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BudgiDeskDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BudgiDeskDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BudgiDeskDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BudgiDeskDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BudgiDeskDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BudgiDeskDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BudgiDeskDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BudgiDeskDB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BudgiDeskDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BudgiDeskDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BudgiDeskDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BudgiDeskDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BudgiDeskDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BudgiDeskDB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BudgiDeskDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BudgiDeskDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [BudgiDeskDB] SET  MULTI_USER 
GO
ALTER DATABASE [BudgiDeskDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BudgiDeskDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BudgiDeskDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BudgiDeskDB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [BudgiDeskDB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [BudgiDeskDB]
GO
/****** Object:  Table [dbo].[Accessory]    Script Date: 12/29/2015 6:48:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accessory](
	[AccessoriesID] [int] NOT NULL,
	[Jewellary] [int] NULL,
	[Perfumes] [int] NULL,
	[InteriorDecor] [int] NULL,
	[Cosmetics] [int] NULL,
	[Clothes] [int] NULL,
	[Shoes] [int] NULL,
 CONSTRAINT [PK_Accessory] PRIMARY KEY CLUSTERED 
(
	[AccessoriesID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Amount]    Script Date: 12/29/2015 6:48:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Amount](
	[UserID] [varchar](50) NOT NULL,
	[PersonalAmount] [int] NULL,
	[HomeAmount] [int] NULL,
 CONSTRAINT [PK_Amount] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[AmountSpent]    Script Date: 12/29/2015 6:48:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[AmountSpent](
	[UserID] [varchar](50) NOT NULL,
	[SpentHomeAmount] [bigint] NULL,
	[DateOfSpentAmount] [datetime] NOT NULL,
	[SpentPersonalAmount] [bigint] NULL
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Bill]    Script Date: 12/29/2015 6:48:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Bill](
	[BillsID] [int] NOT NULL,
	[Electricity] [int] NULL,
	[Gas] [int] NULL,
	[Phone] [int] NULL,
	[Water] [int] NULL,
	[Medical] [int] NULL,
	[Education] [int] NULL,
 CONSTRAINT [PK_Bill] PRIMARY KEY CLUSTERED 
(
	[BillsID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Budget]    Script Date: 12/29/2015 6:48:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Budget](
	[UserID] [varchar](50) NULL,
	[BillsID] [int] NULL,
	[FoodID] [int] NULL,
	[GroceryID] [int] NULL,
	[AccessoriesID] [int] NULL,
	[DateOfBudget] [datetime] NOT NULL,
 CONSTRAINT [PK_Budget_1] PRIMARY KEY CLUSTERED 
(
	[DateOfBudget] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Category]    Script Date: 12/29/2015 6:48:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CID] [int] IDENTITY(1,1) NOT NULL,
	[CName] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Earning]    Script Date: 12/29/2015 6:48:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Earning](
	[ErID] [int] IDENTITY(1,1) NOT NULL,
	[price] [int] NOT NULL,
	[UID] [varchar](50) NOT NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK_Earning] PRIMARY KEY CLUSTERED 
(
	[ErID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Expenses]    Script Date: 12/29/2015 6:48:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Expenses](
	[EID] [int] IDENTITY(1,1) NOT NULL,
	[UID] [varchar](50) NOT NULL,
	[Price] [int] NOT NULL,
	[Location] [nchar](50) NOT NULL,
	[Date] [datetime] NOT NULL,
	[CID] [int] NOT NULL,
 CONSTRAINT [PK_Expenses] PRIMARY KEY CLUSTERED 
(
	[EID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Food]    Script Date: 12/29/2015 6:48:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Food](
	[FoodID] [int] NOT NULL,
	[Vegetables] [int] NULL,
	[Fruits] [int] NULL,
	[Meat] [int] NULL,
	[Milk] [int] NULL,
 CONSTRAINT [PK_Food] PRIMARY KEY CLUSTERED 
(
	[FoodID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Grocery]    Script Date: 12/29/2015 6:48:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Grocery](
	[GroceryID] [int] NOT NULL,
	[Cereals] [int] NULL,
	[Soap] [int] NULL,
	[Shampoo] [int] NULL,
	[Lotion] [int] NULL,
	[Oil] [int] NULL,
	[Deoderants] [int] NULL,
	[Surf] [int] NULL,
	[ToothPaste] [int] NULL,
	[CleaningLiquids] [int] NULL,
	[Tea] [int] NULL,
	[EnergyDrinks] [int] NULL,
	[Spices] [int] NULL,
 CONSTRAINT [PK_Grocery] PRIMARY KEY CLUSTERED 
(
	[GroceryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PersonalBudget]    Script Date: 12/29/2015 6:48:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PersonalBudget](
	[UserID] [varchar](50) NULL,
	[BusFair] [int] NULL,
	[WithFriends] [int] NULL,
	[OnMySelf] [int] NULL,
	[Gifts] [int] NULL,
	[Extra] [int] NULL,
	[Clothes] [int] NULL,
	[Phone] [int] NULL,
	[Date] [datetime] NOT NULL,
 CONSTRAINT [PK_PersonalBudget2] PRIMARY KEY CLUSTERED 
(
	[Date] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UserAccount]    Script Date: 12/29/2015 6:48:18 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UserAccount](
	[ID] [varchar](50) NOT NULL,
	[Name] [varchar](50) NULL,
	[PhoneNumber] [varchar](50) NULL,
	[Age] [int] NULL,
	[Gender] [bit] NULL,
	[UserName] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
 CONSTRAINT [PK_UserAccount] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
ALTER TABLE [dbo].[Amount]  WITH CHECK ADD  CONSTRAINT [FK_Amount_UserAccount] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserAccount] ([ID])
GO
ALTER TABLE [dbo].[Amount] CHECK CONSTRAINT [FK_Amount_UserAccount]
GO
ALTER TABLE [dbo].[Budget]  WITH CHECK ADD  CONSTRAINT [FK_Budget_Accessory] FOREIGN KEY([AccessoriesID])
REFERENCES [dbo].[Accessory] ([AccessoriesID])
GO
ALTER TABLE [dbo].[Budget] CHECK CONSTRAINT [FK_Budget_Accessory]
GO
ALTER TABLE [dbo].[Budget]  WITH CHECK ADD  CONSTRAINT [FK_Budget_Bill] FOREIGN KEY([BillsID])
REFERENCES [dbo].[Bill] ([BillsID])
GO
ALTER TABLE [dbo].[Budget] CHECK CONSTRAINT [FK_Budget_Bill]
GO
ALTER TABLE [dbo].[Budget]  WITH CHECK ADD  CONSTRAINT [FK_Budget_Food] FOREIGN KEY([FoodID])
REFERENCES [dbo].[Food] ([FoodID])
GO
ALTER TABLE [dbo].[Budget] CHECK CONSTRAINT [FK_Budget_Food]
GO
ALTER TABLE [dbo].[Budget]  WITH CHECK ADD  CONSTRAINT [FK_Budget_Grocery] FOREIGN KEY([GroceryID])
REFERENCES [dbo].[Grocery] ([GroceryID])
GO
ALTER TABLE [dbo].[Budget] CHECK CONSTRAINT [FK_Budget_Grocery]
GO
ALTER TABLE [dbo].[Budget]  WITH CHECK ADD  CONSTRAINT [FK_Budget_UserAccount] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserAccount] ([ID])
GO
ALTER TABLE [dbo].[Budget] CHECK CONSTRAINT [FK_Budget_UserAccount]
GO
ALTER TABLE [dbo].[PersonalBudget]  WITH CHECK ADD  CONSTRAINT [FK_PersonalBudget_UserAccount] FOREIGN KEY([UserID])
REFERENCES [dbo].[UserAccount] ([ID])
GO
ALTER TABLE [dbo].[PersonalBudget] CHECK CONSTRAINT [FK_PersonalBudget_UserAccount]
GO
USE [master]
GO
ALTER DATABASE [BudgiDeskDB] SET  READ_WRITE 
GO
