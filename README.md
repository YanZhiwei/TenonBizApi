# TenonBizApi

## 概述

**TenonBizApi** 是一个专为开发者设计的高效 ASP.NET Core Web API 项目模板，旨在简化 Web 应用的开发流程。它使开发者能够快速启动项目，并通过集成 [YanZhiwei/Tenon](https://github.com/YanZhiwei/Tenon) 提供的多种功能模块，如服务治理、分布式缓存和消息队列等，提供了一个基于三层架构的解决方案。

这一模板消除了从零开始开发基础功能的繁琐过程，开发者只需专注于业务逻辑的实现。凭借其开箱即用的特性，TenonBizApi 显著提升了开发效率，是构建现代化 Web API 应用的理想选择。

## 主要功能

TenonBizApi 提供了一系列开箱即用的服务，简化了 Web API 项目的开发过程：

- **服务治理**：通过 Consul 实现服务的注册与发现，确保服务的高可用性和动态扩展。
- **分布式缓存与锁**：利用 Redis 提供高效的缓存机制、分布式锁和布隆过滤器，优化系统性能和数据一致性。
- **分布式总线**：集成 Cap 框架，支持事件驱动架构，实现服务间的异步通信。
- **分布式 ID 生成**：采用 Snowflake 算法，确保在分布式环境下生成唯一的标识符。
- **消息队列**：通过 RabbitMQ 提供可靠的消息队列服务，支持异步处理和系统解耦。
- **数据库访问**：结合 Entity Framework Core 和 Repository 模式，简化数据访问层的开发。
- **API 网关**：利用 Ocelot 提供强大的 API 网关功能，支持路由、负载均衡和安全控制。

## 项目结构

- **src/**: 包含应用程序的主要源代码。
  - **TenonBizApi/**: 主项目模块，包含核心功能实现。
  - **TenonBizApi.AppHost/**: 负责应用的主机配置和启动。
  - **TenonBizApi.Application/**: 应用程序的核心业务逻辑。
  - **TenonBizApi.Application.Abstractions/**: 定义应用程序的抽象层和接口。
  - **TenonBizApi.Repository/**: 数据存储和访问层。
  - **TenonBizApi.ServiceDefaults/**: 定义服务的默认配置和实现。

- **tests/**: 包含测试项目。
  - **TenonBizApi.Application.UnitTests/**: 用于 `TenonBizApi.Application` 模块的单元测试。
  - **TenonBizApi.IntegrationTests/**: 用于集成测试，验证模块间的交互。

## 测试指南

### 运行测试
要执行测试，请导航到 `tests` 目录并运行以下命令：
```
dotnet test
```
这将运行所有单元测试和集成测试，确保项目的功能正常。

## 入门指南

### 先决条件
- [.NET Core SDK](https://dotnet.microsoft.com/download) (版本 9.0 或更高)
- [Visual Studio](https://visualstudio.microsoft.com/) 或 [Visual Studio Code](https://code.visualstudio.com/)

### 构建项目
要构建项目，请导航到根目录并运行以下命令：
```
dotnet build
```

### 运行应用程序
要运行应用程序，请使用以下命令：
```
dotnet run --project src/TenonBizApi
```

### 运行测试
要执行测试，请导航到 `tests` 目录并运行：
```
dotnet test
```

## 贡献

如果这个项目对你有所帮助，请考虑为我们点亮一颗 Star！你的支持将激励我不断完善和提升项目质量。

我们欢迎所有形式的贡献！你可以通过 fork 此仓库并提交 pull 请求来帮助我们改进和扩展功能。

## 许可证
此项目根据 MIT 许可证授权 - 有关详细信息，请参阅 [LICENSE](LICENSE) 文件。
