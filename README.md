# Proje Açıklaması

Bu proje, [OBilet API] üzerinden oturum yönetimi ve seyahat bilgileri almak için kullanılan bir MVC - ASP.NET Core uygulamasını içerir.

## SessionController

`SessionController`, oturum yönetimiyle ilgili API çağrılarını işleyen bir controller sınıfını içerir.

### Metodlar:

#### 1. `GetSession` Metodu

- **Açıklama:** Verilen oturum modeline dayanarak oturum verilerini alır.
- **HTTP Metodu:** POST
- **Yol:** `/GetSession`
- **Parametre:** `SessionModel`: Oturum modeli.
- **Dönüş Değeri:** `Task<CoreResponse<SessionResponseModel>>`: Asenkron işlemi temsil eden bir görev, oturum yanıt modeliyle birlikte.

## TravelController

`TravelController`, seyahat bilgileriyle ilgili API çağrılarını işleyen bir controller sınıfını içerir.

### Metodlar:

#### 1. `GetBusLocations` Metodu

- **Açıklama:** Verilen otobüs konumları modeline dayanarak otobüs konumlarını alır.
- **HTTP Metodu:** POST
- **Yol:** `/GetBusLocations`
- **Parametre:** `BusLocationsModel`: Otobüs konumları modeli.
- **Dönüş Değeri:** `Task<CoreResponse<BusLocationsResponseModel>>`: Asenkron işlemi temsil eden bir görev, otobüs konumları yanıt modeliyle birlikte.

#### 2. `GetBusJourneys` Metodu

- **Açıklama:** Verilen otobüs seferleri modeline dayanarak otobüs seferlerini alır.
- **HTTP Metodu:** POST
- **Yol:** `/GetBusJourneys`
- **Parametre:** `BusJourneysModel`: Otobüs seferleri modeli.
- **Dönüş Değeri:** `Task<CoreResponse<BusJourneysResponseModel>>`: Asenkron işlemi temsil eden bir görev, otobüs seferleri yanıt modeliyle birlikte.

# Bağımlılıklar ve Kullanım

Bu proje, `IOBiletApiSessionProcessor` ve `IOBiletApiTravelProcessor` arabirimlerine dayanarak OBilet API ile etkileşimde bulunur. Bu arabirimleri uygulayan sınıfları enjekte ederek uygun API çağrılarını gerçekleştirebilirsiniz.

## Uygulama Başlatma

Uygulamayı başlatmak için, projeyi bir IDE'de açın ve gerekli bağımlılıkları yükledikten sonra `SessionController` ve `TravelController` sınıflarını kullanarak API çağrıları yapabilirsiniz.
