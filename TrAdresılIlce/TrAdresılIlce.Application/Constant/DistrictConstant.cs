namespace TrAdresılIlce.Application.Constant;

public static class DistrictConstant
{
    public static readonly (int ProvinceId, string DistrictName)[] Districts = new[]
    {
    // Adana (1)
    (1, "Aladağ"), (1, "Ceyhan"), (1, "Çukurova"), (1, "Feke"), (1, "İmamoğlu"), (1, "Karaisalı"), (1, "Karataş"), (1, "Kozan"), (1, "Pozantı"), (1, "Saimbeyli"), (1, "Sarıçam"), (1, "Seyhan"), (1, "Tufanbeyli"), (1, "Yumurtalık"), (1, "Yüreğir"),
    // Adıyaman (2)
    (2, "Besni"), (2, "Çelikhan"), (2, "Gerger"), (2, "Gölbaşı"), (2, "Kahta"), (2, "Merkez"), (2, "Samsat"), (2, "Sincik"), (2, "Tut"),
    // Afyonkarahisar (3)
    (3, "Başmakçı"), (3, "Bayat"), (3, "Bolvadin"), (3, "Çay"), (3, "Çobanlar"), (3, "Dazkırı"), (3, "Dinar"), (3, "Emirdağ"), (3, "Evciler"), (3, "Hocalar"), (3, "İhsaniye"), (3, "İscehisar"), (3, "Kızılören"), (3, "Merkez"), (3, "Sandıklı"), (3, "Sinanpaşa"), (3, "Sultandağı"), (3, "Şuhut"),
    // Ağrı (4)
    (4, "Diyadin"), (4, "Doğubayazıt"), (4, "Eleşkirt"), (4, "Hamur"), (4, "Merkez"), (4, "Patnos"), (4, "Taşlıçay"), (4, "Tutak"),
    // Amasya (5)
    (5, "Göynücek"), (5, "Gümüşhacıköy"), (5, "Hamamözü"), (5, "Merkez"), (5, "Merzifon"), (5, "Suluova"), (5, "Taşova"),
    // Ankara (6)
    (6, "Altındağ"), (6, "Ayaş"), (6, "Bala"), (6, "Beypazarı"), (6, "Çamlıdere"), (6, "Çankaya"), (6, "Çubuk"), (6, "Elmadağ"), (6, "Etimesgut"), (6, "Evren"), (6, "Gölbaşı"), (6, "Güdül"), (6, "Haymana"), (6, "Kahramankazan"), (6, "Kalecik"), (6, "Keçiören"), (6, "Kızılcahamam"), (6, "Mamak"), (6, "Nallıhan"), (6, "Polatlı"), (6, "Pursaklar"), (6, "Sincan"), (6, "Şereflikoçhisar"), (6, "Yenimahalle"),
    // Antalya (7)
    (7, "Akseki"), (7, "Aksu"), (7, "Alanya"), (7, "Demre"), (7, "Döşemealtı"), (7, "Elmalı"), (7, "Finike"), (7, "Gazipaşa"), (7, "Gündoğmuş"), (7, "İbradı"), (7, "Kemer"), (7, "Kepez"), (7, "Konyaaltı"), (7, "Korkuteli"), (7, "Kumluca"), (7, "Manavgat"), (7, "Muratpaşa"), (7, "Serik"),
    // Artvin (8)
    (8, "Ardanuç"), (8, "Arhavi"), (8, "Borçka"), (8, "Hopa"), (8, "Kemalpaşa"), (8, "Merkez"), (8, "Murgul"), (8, "Şavşat"), (8, "Yusufeli"),
    // Aydın (9)
    (9, "Bozdoğan"), (9, "Buharkent"), (9, "Çine"), (9, "Didim"), (9, "Efeler"), (9, "Germencik"), (9, "İncirliova"), (9, "Karpuzlu"), (9, "Koçarlı"), (9, "Köşk"), (9, "Kuşadası"), (9, "Kuyucak"), (9, "Nazilli"), (9, "Söke"), (9, "Sultanhisar"), (9, "Yenipazar"),
    // Balıkesir (10)
    (10, "Altıeylül"), (10, "Ayvalık"), (10, "Balya"), (10, "Bandırma"), (10, "Bigadiç"), (10, "Burhaniye"), (10, "Dursunbey"), (10, "Edremit"), (10, "Erdek"), (10, "Gömeç"), (10, "Gönen"), (10, "Havran"), (10, "İvrindi"), (10, "Karesi"), (10, "Kepsut"), (10, "Manyas"), (10, "Marmara"), (10, "Savaştepe"), (10, "Sındırgı"), (10, "Susurluk"),
    // Bilecik (11)
    (11, "Bozüyük"), (11, "Gölpazarı"), (11, "İnhisar"), (11, "Merkez"), (11, "Osmaneli"), (11, "Pazaryeri"), (11, "Söğüt"), (11, "Yenipazar"),
    // Bingöl (12)
    (12, "Adaklı"), (12, "Genç"), (12, "Karlıova"), (12, "Kiğı"), (12, "Merkez"), (12, "Solhan"), (12, "Yayladere"), (12, "Yedisu"),
    // Bitlis (13)
    (13, "Adilcevaz"), (13, "Ahlat"), (13, "Güroymak"), (13, "Hizan"), (13, "Merkez"), (13, "Mutki"), (13, "Tatvan"),
    // Bolu (14)
    (14, "Dörtdivan"), (14, "Gerede"), (14, "Göynük"), (14, "Kıbrıscık"), (14, "Mengen"), (14, "Merkez"), (14, "Mudurnu"), (14, "Seben"), (14, "Yeniçağa"),
    // Burdur (15)
    (15, "Ağlasun"), (15, "Altınyayla"), (15, "Bucak"), (15, "Çavdır"), (15, "Çeltikçi"), (15, "Gölhisar"), (15, "Karamanlı"), (15, "Kemer"), (15, "Merkez"), (15, "Tefenni"), (15, "Yeşilova"),
    // Bursa (16)
    (16, "Büyükorhan"), (16, "Gemlik"), (16, "Gürsu"), (16, "Harmancık"), (16, "İnegöl"), (16, "İznik"), (16, "Karacabey"), (16, "Keles"), (16, "Kestel"), (16, "Mudanya"), (16, "Mustafakemalpaşa"), (16, "Nilüfer"), (16, "Orhaneli"), (16, "Orhangazi"), (16, "Osmangazi"), (16, "Yenişehir"),
    // Çanakkale (17)
    (17, "Ayvacık"), (17, "Bayramiç"), (17, "Biga"), (17, "Bozcaada"), (17, "Çan"), (17, "Eceabat"), (17, "Ezine"), (17, "Gelibolu"), (17, "Gökçeada"), (17, "Lapseki"), (17, "Merkez"), (17, "Yenice"),
    // Çankırı (18)
    (18, "Atkaracalar"), (18, "Bayramören"), (18, "Çerkeş"), (18, "Eldivan"), (18, "Ilgaz"), (18, "Kızılırmak"), (18, "Korgun"), (18, "Kurşunlu"), (18, "Merkez"), (18, "Orta"), (18, "Şabanözü"), (18, "Yapraklı"),
    // Çorum (19)
    (19, "Alaca"), (19, "Bayat"), (19, "Boğazkale"), (19, "Dodurga"), (19, "İskilip"), (19, "Kargı"), (19, "Laçin"), (19, "Mecitözü"), (19, "Merkez"), (19, "Oğuzlar"), (19, "Ortaköy"), (19, "Osmancık"), (19, "Sungurlu"), (19, "Uğurludağ"),
    // Denizli (20)
    (20, "Acıpayam"), (20, "Babadağ"), (20, "Baklan"), (20, "Bekilli"), (20, "Beyağaç"), (20, "Bozkurt"), (20, "Buldan"), (20, "Çal"), (20, "Çameli"), (20, "Çardak"), (20, "Çivril"), (20, "Güney"), (20, "Honaz"), (20, "Kale"), (20, "Merkezefendi"), (20, "Pamukkale"), (20, "Sarayköy"), (20, "Serinhisar"), (20, "Tavas"),
    // Diyarbakır (21)
    (21, "Bağlar"), (21, "Bismil"), (21, "Çermik"), (21, "Çınar"), (21, "Çüngüş"), (21, "Dicle"), (21, "Eğil"), (21, "Ergani"), (21, "Hani"), (21, "Hazro"), (21, "Kayapınar"), (21, "Kocaköy"), (21, "Kulp"), (21, "Lice"), (21, "Silvan"), (21, "Sur"), (21, "Yenişehir"),
    // Edirne (22)
    (22, "Enez"), (22, "Havsa"), (22, "İpsala"), (22, "Keşan"), (22, "Lalapaşa"), (22, "Meriç"), (22, "Merkez"), (22, "Süloğlu"), (22, "Uzunköprü"),
    // Elazığ (23)
    (23, "Ağın"), (23, "Alacakaya"), (23, "Arıcak"), (23, "Baskil"), (23, "Karakoçan"), (23, "Keban"), (23, "Kovancılar"), (23, "Maden"), (23, "Merkez"), (23, "Palu"), (23, "Sivrice"),
    // Erzincan (24)
    (24, "Çayırlı"), (24, "İliç"), (24, "Kemah"), (24, "Kemaliye"), (24, "Merkez"), (24, "Otlukbeli"), (24, "Refahiye"), (24, "Tercan"), (24, "Üzümlü"),
    // Erzurum (25)
    (25, "Aşkale"), (25, "Aziziye"), (25, "Çat"), (25, "Hınıs"), (25, "Horasan"), (25, "İspir"), (25, "Karaçoban"), (25, "Karayazı"), (25, "Köprüköy"), (25, "Narman"), (25, "Oltu"), (25, "Olur"), (25, "Palandöken"), (25, "Pasinler"), (25, "Pazaryolu"), (25, "Şenkaya"), (25, "Tekman"), (25, "Tortum"), (25, "Uzundere"), (25, "Yakutiye"),
    // Eskişehir (26)
    (26, "Alpu"), (26, "Beylikova"), (26, "Çifteler"), (26, "Günyüzü"), (26, "Han"), (26, "İnönü"), (26, "Mahmudiye"), (26, "Mihalgazi"), (26, "Mihalıççık"), (26, "Odunpazarı"), (26, "Sarıcakaya"), (26, "Seyitgazi"), (26, "Sivrihisar"), (26, "Tepebaşı"),
    // Gaziantep (27)
    (27, "Araban"), (27, "İslahiye"), (27, "Karkamış"), (27, "Nizip"), (27, "Nurdağı"), (27, "Oğuzeli"), (27, "Şahinbey"), (27, "Şehitkamil"), (27, "Yavuzeli"),
    // Giresun (28)
    (28, "Alucra"), (28, "Bulancak"), (28, "Çamoluk"), (28, "Çanakçı"), (28, "Dereli"), (28, "Doğankent"), (28, "Espiye"), (28, "Eynesil"), (28, "Görele"), (28, "Güce"), (28, "Keşap"), (28, "Merkez"), (28, "Piraziz"), (28, "Şebinkarahisar"), (28, "Tirebolu"),
    // Gümüşhane (29)
    (29, "Kelkit"), (29, "Köse"), (29, "Kürtün"), (29, "Merkez"), (29, "Şiran"), (29, "Torul"),
    // Hakkari (30)
    (30, "Çukurca"), (30, "Derecik"), (30, "Merkez"), (30, "Şemdinli"), (30, "Yüksekova"),
    // Hatay (31)
    (31, "Altınözü"), (31, "Antakya"), (31, "Arsuz"), (31, "Belen"), (31, "Defne"), (31, "Dörtyol"), (31, "Erzin"), (31, "Hassa"), (31, "İskenderun"), (31, "Kırıkhan"), (31, "Kumlu"), (31, "Payas"), (31, "Reyhanlı"), (31, "Samandağ"),
    // Isparta (32)
    (32, "Aksu"), (32, "Atabey"), (32, "Eğirdir"), (32, "Gelendost"), (32, "Gönen"), (32, "Keçiborlu"), (32, "Merkez"), (32, "Senirkent"), (32, "Sütçüler"), (32, "Şarkikaraağaç"), (32, "Uluborlu"), (32, "Yalvaç"), (32, "Yenişarbademli"),
    // Mersin (33)
    (33, "Akdeniz"), (33, "Anamur"), (33, "Aydıncık"), (33, "Bozyazı"), (33, "Çamlıyayla"), (33, "Erdemli"), (33, "Gülnar"), (33, "Mezitli"), (33, "Mut"), (33, "Silifke"), (33, "Tarsus"), (33, "Toroslar"), (33, "Yenişehir"),
    // İstanbul (34) - zaten mevcut
    // İzmir (35)
    (35, "Aliağa"), (35, "Balçova"), (35, "Bayındır"), (35, "Bergama"), (35, "Beydağ"), (35, "Bornova"), (35, "Buca"), (35, "Çeşme"), (35, "Çiğli"), (35, "Dikili"), (35, "Foça"), (35, "Gaziemir"), (35, "Güzelbahçe"), (35, "Karabağlar"), (35, "Karaburun"), (35, "Karşıyaka"), (35, "Kemalpaşa"), (35, "Kınık"), (35, "Kiraz"), (35, "Konak"), (35, "Menderes"), (35, "Menemen"), (35, "Narlıdere"), (35, "Ödemiş"), (35, "Seferihisar"), (35, "Selçuk"), (35, "Tire"), (35, "Torbalı"), (35, "Urla"),
    // Kars (36)
    (36, "Akyaka"), (36, "Arpaçay"), (36, "Digor"), (36, "Kağızman"), (36, "Merkez"), (36, "Sarıkamış"), (36, "Selim"), (36, "Susuz"),
    // Kastamonu (37)
    (37, "Abana"), (37, "Ağlı"), (37, "Araç"), (37, "Azdavay"), (37, "Bozkurt"), (37, "Cide"), (37, "Çatalzeytin"), (37, "Daday"), (37, "Devrekani"), (37, "Doğanyurt"), (37, "Hanönü"), (37, "İhsangazi"), (37, "İnebolu"), (37, "Küre"), (37, "Merkez"), (37, "Pınarbaşı"), (37, "Şenpazar"), (37, "Seydiler"), (37, "Taşköprü"), (37, "Tosya"),
    // Kayseri (38)
    (38, "Akkışla"), (38, "Bünyan"), (38, "Develi"), (38, "Felahiye"), (38, "Hacılar"), (38, "İncesu"), (38, "Kocasinan"), (38, "Melikgazi"), (38, "Özvatan"), (38, "Pınarbaşı"), (38, "Sarıoğlan"), (38, "Sarız"), (38, "Talas"), (38, "Tomarza"), (38, "Yahyalı"), (38, "Yeşilhisar"),
    // Kırklareli (39)
    (39, "Babaeski"), (39, "Demirköy"), (39, "Kofçaz"), (39, "Lüleburgaz"), (39, "Merkez"), (39, "Pehlivanköy"), (39, "Pınarhisar"), (39, "Vize"),
    // Kırşehir (40)
    (40, "Akçakent"), (40, "Akpınar"), (40, "Boztepe"), (40, "Çiçekdağı"), (40, "Kaman"), (40, "Merkez"), (40, "Mucur"),
    // Kocaeli (41)
    (41, "Başiskele"), (41, "Çayırova"), (41, "Darıca"), (41, "Derince"), (41, "Dilovası"), (41, "Gebze"), (41, "Gölcük"), (41, "İzmit"), (41, "Kandıra"), (41, "Karamürsel"), (41, "Kartepe"), (41, "Körfez"),
    // Konya (42)
    (42, "Ahırlı"), (42, "Akören"), (42, "Akşehir"), (42, "Altınekin"), (42, "Beyşehir"), (42, "Bozkır"), (42, "Cihanbeyli"), (42, "Çeltik"), (42, "Çumra"), (42, "Derbent"), (42, "Derebucak"), (42, "Doğanhisar"), (42, "Emirgazi"), (42, "Ereğli"), (42, "Güneysınır"), (42, "Hadim"), (42, "Halkapınar"), (42, "Hüyük"), (42, "Ilgın"), (42, "Kadınhanı"), (42, "Karapınar"), (42, "Karatay"), (42, "Kulu"), (42, "Meram"), (42, "Sarayönü"), (42, "Selçuklu"), (42, "Seydişehir"), (42, "Taşkent"), (42, "Tuzlukçu"), (42, "Yalıhüyük"), (42, "Yunak"),
    // Kütahya (43)
    (43, "Altıntaş"), (43, "Aslanapa"), (43, "Çavdarhisar"), (43, "Domaniç"), (43, "Dumlupınar"), (43, "Emet"), (43, "Gediz"), (43, "Hisarcık"), (43, "Merkez"), (43, "Pazarlar"), (43, "Simav"), (43, "Şaphane"), (43, "Tavşanlı"),
    // Malatya (44)
    (44, "Akçadağ"), (44, "Arapgir"), (44, "Arguvan"), (44, "Battalgazi"), (44, "Darende"), (44, "Doğanşehir"), (44, "Doğanyol"), (44, "Hekimhan"), (44, "Kale"), (44, "Kuluncak"), (44, "Pütürge"), (44, "Yazıhan"), (44, "Yeşilyurt"),
    // Manisa (45)
    (45, "Ahmetli"), (45, "Akhisar"), (45, "Alaşehir"), (45, "Demirci"), (45, "Gölmarmara"), (45, "Gördes"), (45, "Kırkağaç"), (45, "Köprübaşı"), (45, "Kula"), (45, "Salihli"), (45, "Sarıgöl"), (45, "Saruhanlı"), (45, "Selendi"), (45, "Soma"), (45, "Şehzadeler"), (45, "Turgutlu"), (45, "Yunusemre"),
    // Kahramanmaraş (46)
    (46, "Afşin"), (46, "Andırın"), (46, "Dulkadiroğlu"), (46, "Elbistan"), (46, "Ekinözü"), (46, "Göksun"), (46, "Nurhak"), (46, "Onikişubat"), (46, "Pazarcık"), (46, "Türkoğlu"),
    // Mardin (47)
    (47, "Artuklu"), (47, "Dargeçit"), (47, "Derik"), (47, "Kızıltepe"), (47, "Mazıdağı"), (47, "Midyat"), (47, "Nusaybin"), (47, "Ömerli"), (47, "Savur"), (47, "Yeşilli"),
    // Muğla (48)
    (48, "Bodrum"), (48, "Dalaman"), (48, "Datça"), (48, "Fethiye"), (48, "Kavaklıdere"), (48, "Köyceğiz"), (48, "Marmaris"), (48, "Menteşe"), (48, "Milas"), (48, "Ortaca"), (48, "Seydikemer"), (48, "Ula"), (48, "Yatağan"),
    // Muş (49)
    (49, "Bulanık"), (49, "Hasköy"), (49, "Korkut"), (49, "Malazgirt"), (49, "Merkez"), (49, "Varto"),
    // Nevşehir (50)
    (50, "Avanos"), (50, "Derinkuyu"), (50, "Gülşehir"), (50, "Hacıbektaş"), (50, "Kozaklı"), (50, "Merkez"), (50, "Ürgüp"),
    // Niğde (51)
    (51, "Altunhisar"), (51, "Bor"), (51, "Çamardı"), (51, "Çiftlik"), (51, "Merkez"), (51, "Ulukışla"),
    // Ordu (52)
    (52, "Akkuş"), (52, "Altınordu"), (52, "Aybastı"), (52, "Çamaş"), (52, "Çatalpınar"), (52, "Çaybaşı"), (52, "Fatsa"), (52, "Gölköy"), (52, "Gülyalı"), (52, "Gürgentepe"), (52, "İkizce"), (52, "Kabadüz"), (52, "Kabataş"), (52, "Korgan"), (52, "Kumru"), (52, "Mesudiye"), (52, "Perşembe"), (52, "Ulubey"), (52, "Ünye"),
    // Rize (53)
    (53, "Ardeşen"), (53, "Çamlıhemşin"), (53, "Çayeli"), (53, "Derepazarı"), (53, "Fındıklı"), (53, "Güneysu"), (53, "Hemşin"), (53, "İkizdere"), (53, "İyidere"), (53, "Kalkandere"), (53, "Merkez"), (53, "Pazar"),
    // Sakarya (54)
    (54, "Akyazı"), (54, "Arifiye"), (54, "Erenler"), (54, "Ferizli"), (54, "Geyve"), (54, "Hendek"), (54, "Karapürçek"), (54, "Karasu"), (54, "Kaynarca"), (54, "Kocaali"), (54, "Pamukova"), (54, "Sapanca"), (54, "Serdivan"), (54, "Söğütlü"), (54, "Taraklı"),
    // Samsun (55)
    (55, "Alaçam"), (55, "Asarcık"), (55, "Atakum"), (55, "Ayvacık"), (55, "Bafra"), (55, "Canik"), (55, "Çarşamba"), (55, "Havza"), (55, "İlkadım"), (55, "Kavak"), (55, "Ladik"), (55, "Salıpazarı"), (55, "Tekkeköy"), (55, "Terme"), (55, "Vezirköprü"), (55, "Yakakent"),
    // Siirt (56)
    (56, "Baykan"), (56, "Eruh"), (56, "Kurtalan"), (56, "Merkez"), (56, "Pervari"), (56, "Şirvan"), (56, "Tillo"),
    // Sinop (57)
    (57, "Ayancık"), (57, "Boyabat"), (57, "Dikmen"), (57, "Durağan"), (57, "Erfelek"), (57, "Gerze"), (57, "Merkez"), (57, "Saraydüzü"), (57, "Türkeli"),
    // Sivas (58)
    (58, "Akıncılar"), (58, "Altınyayla"), (58, "Divriği"), (58, "Doğanşar"), (58, "Gemerek"), (58, "Gölova"), (58, "Gürün"), (58, "Hafik"), (58, "İmranlı"), (58, "Kangal"), (58, "Koyulhisar"), (58, "Merkez"), (58, "Suşehri"), (58, "Şarkışla"), (58, "Ulaş"), (58, "Yıldızeli"), (58, "Zara"),
    // Tekirdağ (59)
    (59, "Çerkezköy"), (59, "Çorlu"), (59, "Ergene"), (59, "Hayrabolu"), (59, "Kapaklı"), (59, "Malkara"), (59, "Marmaraereğlisi"), (59, "Muratlı"), (59, "Saray"), (59, "Süleymanpaşa"), (59, "Şarköy"),
    // Tokat (60)
    (60, "Almus"), (60, "Artova"), (60, "Başçiftlik"), (60, "Erbaa"), (60, "Merkez"), (60, "Niksar"), (60, "Pazar"), (60, "Reşadiye"), (60, "Sulusaray"), (60, "Turhal"), (60, "Yeşilyurt"), (60, "Zile"),
    // Trabzon (61)
    (61, "Akçaabat"), (61, "Araklı"), (61, "Arsin"), (61, "Beşikdüzü"), (61, "Çarşıbaşı"), (61, "Çaykara"), (61, "Dernekpazarı"), (61, "Düzköy"), (61, "Hayrat"), (61, "Köprübaşı"), (61, "Maçka"), (61, "Of"), (61, "Ortahisar"), (61, "Sürmene"), (61, "Şalpazarı"), (61, "Tonya"), (61, "Vakfıkebir"), (61, "Yomra"),
    // Tunceli (62)
    (62, "Çemişgezek"), (62, "Hozat"), (62, "Mazgirt"), (62, "Nazımiye"), (62, "Ovacık"), (62, "Pertek"), (62, "Pülümür"), (62, "Merkez"),
    // Şanlıurfa (63)
    (63, "Akçakale"), (63, "Birecik"), (63, "Bozova"), (63, "Ceylanpınar"), (63, "Eyyübiye"), (63, "Halfeti"), (63, "Haliliye"), (63, "Harran"), (63, "Hilvan"), (63, "Karaköprü"), (63, "Siverek"), (63, "Suruç"), (63, "Viranşehir"),
    // Uşak (64)
    (64, "Banaz"), (64, "Eşme"), (64, "Karahallı"), (64, "Merkez"), (64, "Sivaslı"), (64, "Ulubey"),
    // Van (65)
    (65, "Bahçesaray"), (65, "Başkale"), (65, "Çaldıran"), (65, "Çatak"), (65, "Edremit"), (65, "Erciş"), (65, "Gevaş"), (65, "Gürpınar"), (65, "İpekyolu"), (65, "Muradiye"), (65, "Özalp"), (65, "Saray"), (65, "Tuşba"),
    // Yozgat (66)
    (66, "Akdağmadeni"), (66, "Aydıncık"), (66, "Boğazlıyan"), (66, "Çandır"), (66, "Çayıralan"), (66, "Çekerek"), (66, "Kadışehri"), (66, "Merkez"), (66, "Saraykent"), (66, "Sarıkaya"), (66, "Sorgun"), (66, "Şefaatli"), (66, "Yenifakılı"), (66, "Yerköy"),
    // Zonguldak (67)
    (67, "Alaplı"), (67, "Çaycuma"), (67, "Devrek"), (67, "Gökçebey"), (67, "Kilimli"), (67, "Kozlu"), (67, "Karadeniz Ereğli"), (67, "Merkez"),
    // Aksaray (68)
    (68, "Ağaçören"), (68, "Eskil"), (68, "Gülağaç"), (68, "Güzelyurt"), (68, "Merkez"), (68, "Ortaköy"), (68, "Sarıyahşi"), (68, "Sultanhanı"),
    // Bayburt (69)
    (69, "Aydıntepe"), (69, "Demirözü"), (69, "Merkez"),
    // Karaman (70)
    (70, "Ayrancı"), (70, "Başyayla"), (70, "Ermenek"), (70, "Kazımkarabekir"), (70, "Merkez"), (70, "Sarıveliler"),
    // Kırıkkale (71)
    (71, "Bahşılı"), (71, "Balışeyh"), (71, "Çelebi"), (71, "Delice"), (71, "Karakeçili"), (71, "Keskin"), (71, "Merkez"), (71, "Sulakyurt"), (71, "Yahşihan"),
    // Batman (72)
    (72, "Beşiri"), (72, "Gercüş"), (72, "Hasankeyf"), (72, "Kozluk"), (72, "Merkez"), (72, "Sason"),
    // Şırnak (73)
    (73, "Beytüşşebap"), (73, "Cizre"), (73, "Güçlükonak"), (73, "İdil"), (73, "Merkez"), (73, "Silopi"), (73, "Uludere"),
    // Bartın (74)
    (74, "Amasra"), (74, "Kurucaşile"), (74, "Merkez"), (74, "Ulus"),
    // Ardahan (75)
    (75, "Çıldır"), (75, "Damal"), (75, "Göle"), (75, "Hanak"), (75, "Merkez"), (75, "Posof"),
    // Iğdır (76)
    (76, "Aralık"), (76, "Karakoyunlu"), (76, "Merkez"), (76, "Tuzluca"),
    // Yalova (77)
    (77, "Altınova"), (77, "Armutlu"), (77, "Çınarcık"), (77, "Çiftlikköy"), (77, "Merkez"), (77, "Termal"),
    // Karabük (78)
    (78, "Eflani"), (78, "Eskipazar"), (78, "Merkez"), (78, "Ovacık"), (78, "Safranbolu"), (78, "Yenice"),
    // Kilis (79)
    (79, "Elbeyli"), (79, "Merkez"), (79, "Musabeyli"), (79, "Polateli"),
    // Osmaniye (80)
    (80, "Bahçe"), (80, "Düziçi"), (80, "Hasanbeyli"), (80, "Kadirli"), (80, "Merkez"), (80, "Sumbas"), (80, "Toprakkale"),
    // Düzce (81)
    (81, "Akçakoca"), (81, "Cumayeri"), (81, "Çilimli"), (81, "Gölyaka"), (81, "Gümüşova"), (81, "Kaynaşlı"), (81, "Merkez"), (81, "Yığılca"),
};
}