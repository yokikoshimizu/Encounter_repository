# Encounter

Mother風のRPGを作るプロジェクトです。

## 目次

- [ストーリー](#ストーリー)
- [概要](#概要)
- [インストール](#インストール)
- [フォルダ構成](#フォルダ構成)
- [使用方法](#使用方法)
- [開発](#開発)

## ストーリー

- 198×年、トーホク地方の小さな村で平穏に暮らしていた少年リンネは、夜空に突如現れた謎の光を目撃する。
 それは地球によく似た別世界から飛来した生命体だった。
 テレビの特集番組では、トーキョー地方が異生物に攻められ壊滅している様子が映し出されていた。
 そののち、リンネの村もその脅威にさらされ、リンネは世界を救うための旅に出ることを決意する。

## 特徴

- **タイトル:** Encounter（仮）
- **ジャンル:** RPG
- **プラットフォーム:** 未定
- **プレイ人数:** 1人
- **サービス地域:** 日本
- **価格:** 未定
- **配信開始:** 2025年頃（前編）

## インストール

0. **Github Desktopをダウンロード:**
   - [Github Desktop](https://docs.github.com/ja/desktop/installing-and-authenticating-to-github-desktop/installing-github-desktop)をインストールしてください。
   
2. **リポジトリをクローン:**
   - ここ (https://github.com/yokikoshimizu/Encounter_repository) から **Code** → **Open with GitHub Desktop**を選択し、指示に従ってください。

4. **Unityでプロジェクトを開く:**
   - [Unity Hub](https://unity.com/download)をインストールしていることを確認してください。
   - Unity Hubを開き、「Add」をクリックして、クローンしたリポジトリのフォルダを選択します。
   - プロジェクトを選択して開きます。

5. **依存関係のインストール:**
   - プロジェクトを最初に開いた際に、Unityが必要なパッケージをインストールするように促しますので、それに従ってください。
  
## フォルダ構成

**Unityに素材を追加する際には、必ずフォルダ構成に従ってください。**

<pre>
Assets
└── Common
    ├── Graphics
    ├── Audio
    ├── Prefabs
    ├── Scenes
    ├── Scripts
    │   ├── Editor
    │   └── etc..
    └── etc...
└── Plugins
└── etc...
</pre>

## 使用方法

Unityでプロジェクトをロードした後:

1. **シーン:**
   - メインシーンは `Assets/Common/Scenes/` にあります。
   - このシーンを開き、Unityの再生ボタンを押してゲームを開始します。

2. **操作方法(仮):**
   - 移動: `WASD` または 矢印キー
   - インタラクト: `E`
   - ポーズ: `Esc`

3. **ゲームのビルド:**
   - ゲームをビルドするには、`File > Build Settings`に進み、ターゲットプラットフォームを選択して「Build」をクリックします。

## 開発

### 必要なもの

- Unity (バージョンは未定)
- Visual Studio または任意のC# IDE
- GitHub Desktop

### ブランチ

とりあえず、GitHub-Flowに従おうと思います。

- `main`: メインブランチ。
- `その他の機能用ブランチ`: 機能開発用

### 開発環境のセットアップ

1. リポジトリをフォークしてクローンします。
2. 新しい機能やバグ修正のためのブランチを作成:
    ```sh
    git checkout -b feature-name
    ```
3. 変更を加え、意味のあるコミットメッセージとともにコミットします:
    ```sh
    git commit -m "新しい機能Xを追加"
    ```
4. ブランチにプッシュ:
    ```sh
    git push origin feature-name
    ```
5. プルリクエストを作成:
