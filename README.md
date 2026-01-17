# susxBookHouse
susxBookHouse 是一個基於 Clean Architecture 與 領域驅動設計 (DDD) 原則構建的現代化書籍管理 API
本專案旨在展示如何透過層級解耦與強大的設計模式，構建一個具備高度可測試性、可維護性的企業級後端系統

## 架構設計 (Architecture)
本專案嚴格遵循 Clean Architecture 核心原則，將業務邏輯與外部框架完全分離

## Domain 
領域層
核心實體（如 Book）、值物件與領域異常。不依賴於任何外部程式庫或層級

## Application
應用層
包含所有業務案例 (Use Cases)，透過 CQRS (MediatR) 處理指令與查詢，並實作 FluentValidation 進行輸入驗證

## Infrastructure
基礎設施層
處理橫切關注點 (Cross-cutting Concerns)，如身份驗證、權限授權

## Persistence
持久化層
使用 EF Core 搭配 PostgreSQL，並實作實體配置分離

## Presentation
呈現層
基於 ASP.NET Core Web API，作為系統的進入點

### // TODO
### 技術特色 (Key Features)
專屬 SharedKernel: 封裝常用的 DDD 抽象（Entity, ValueObject, AggregateRoot）

### CQRS 模式
透過 MediatR 實現讀寫分離，提升代碼清晰度

### 結構化日誌
整合 Serilog 並透過 Seq 進行實時日誌監控與分析

### 進階授權
實作基於權限 (Permission-based) 的授權機制

### 自動化測試

- Unit Tests: 確保核心業務邏輯準確
- Architecture Tests: 透過 NetArchTest 確保專案引用關係不被破壞
- API 版本控管: 確保後續開發的向下相容性


